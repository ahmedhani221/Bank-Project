using System;
using System.Collections.Generic;
using System.IO;

namespace CoreClassLib
{
    public class User : Person
    {
        public User(string username, string password, string firstName, string lastName, string email, string phone, short permission): base(firstName, lastName, email, phone)
        {
            Username = username;
            Password = password;
            Permission = permission;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public short Permission { get; set; }

        private bool isMarkedDeleted = false;

        static private string EncryptPassword(string password, short encryptionKey)
        {
            char[] encryptedPassword = password.ToCharArray();

            for (int i = 0; i < encryptedPassword.Length; i++)
            {
                encryptedPassword[i] = Convert.ToChar(Convert.ToInt32(encryptedPassword[i] + encryptionKey));
            }

            return encryptedPassword.ToString();
        }

        static private string DecryptPassword(string password, short decryptionKey)
        {
            char[] decryptedPassword = password.ToCharArray();

            for (int i = 0; i < decryptedPassword.Length; i++)
            {
                decryptedPassword[i] = Convert.ToChar(Convert.ToInt32(decryptedPassword[i] - decryptionKey));
            }

            return decryptedPassword.ToString();
        }

        static private User _ConvertLineToUser(string Line, string Separator = "#//#")
        {
            string[] user = Line.Split(new string[] { Separator }, StringSplitOptions.None);

            if (user.Length != 7)
            {
                throw new Exception("Expected 7 fields but found " + user.Length);
            }

            return new User(user[0], user[1], user[2], user[3], user[4], user[5], Convert.ToInt16(user[6]));
        }

        static private string _ConvertUserToLine(User user, string Separator = "#//#")
        {
            string Line = "";

            Line = user.Username + Separator;
            Line += /*EncryptPassword(*/user.Password/*, 5)*/ + Separator;
            Line += user.FirstName + Separator;
            Line += user.LastName + Separator;
            Line += user.Email + Separator;
            Line += user.Phone + Separator;
            Line += user.Permission.ToString();

            return Line;
        }

        static private void _AddLineToFile(string Line)
        {
            File.AppendAllText("users.txt", Line + Environment.NewLine);
        }

        static public List<User> GetUsersData()
        {
            List<User> users = new List<User>();

            foreach(string line in File.ReadLines("users.txt"))
            {
                users.Add(_ConvertLineToUser(line));
            }

            return users;
        }

        static private void _SaveUserData(List<User> users)
        {
            List<string> lines = new List<string>();

            foreach(User user in users)
            {
                if (user.isMarkedDeleted == false)
                    lines.Add(_ConvertUserToLine(user));
            }

            File.WriteAllLines("users.txt", lines);
        }

        public void Add()
        {
            _AddLineToFile(_ConvertUserToLine(this));
        }

        public bool Delete()
        {
            List<User> users = GetUsersData();

            for(int i = 0; i < users.Count; i++)
            {
                if (users[i].Username == this.Username)
                {
                    users[i].isMarkedDeleted = true;
                    break;
                }
            }

            _SaveUserData(users);
            return true;
        }

        public void Update()
        {
            List<User> users = GetUsersData();
            bool isUpdated = false;

            for(int i = 0;i < users.Count;i++)
            {
                if (users[i].Username == this.Username)
                {
                    users[i] = this;
                    isUpdated = true;
                    break;
                }
            }

            if (isUpdated)
            {
                _SaveUserData(users);
            }
        }

        static public User Find(string username)
        {
            List<User> users = GetUsersData();

            foreach (User user in users)
            {
                if (user.Username == username)
                {
                    return user;
                }
            }

            return null;
        }

        static public User Find(string username, string password)
        {
            List<User> users = GetUsersData();

            foreach(User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }

        public bool CheckPermission(short permission)
        {
            return (this.Permission == -1 || (this.Permission & permission) == permission) ? true : false;
        }

        static public bool CheckPermission(User user, short permission)
        {
            return (user.Permission == -1 || (user.Permission & permission) == permission) ? true : false;
        }
    }
}
