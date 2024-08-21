namespace CoreClassLib
{
    public class Person
    {
        public Person(string firstName, string lastName, string email, string phone) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FullName { get {  return FirstName + ' ' + LastName; } }
    }
}
