using System;
using System.Collections.Generic;
using System.IO;

namespace CoreClassLib
{
    public class Client : Person
    {
        public Client(string accountNum, string pinCode, string firstName, string lastName, string email, string phone, decimal balance) : base(firstName, lastName, email, phone) 
        { 
            AccountNum = accountNum;
            PinCode = pinCode;
            Balance = balance;
        }

        public string AccountNum { get; set; }
        public string PinCode { get; set; }
        public decimal Balance { get; set; }

        private bool isMarkedDeleted = false;

        static private Client _ConvertLineToClient(string Line, string Separator = "#//#")
        {
            string[] client = Line.Split(new string[] { Separator }, StringSplitOptions.None);
            return new Client(client[0], client[1], client[2], client[3], client[4], client[5], Convert.ToDecimal(client[6]));
        }

        static private string _ConvertClientToLine(Client client, string Separator = "#//#")
        {
            string Line = "";

            Line = client.AccountNum + Separator;
            Line += client.PinCode + Separator;
            Line += client.FirstName + Separator;
            Line += client.LastName + Separator;
            Line += client.Email + Separator;
            Line += client.Phone + Separator;
            Line += client.Balance.ToString();

            return Line;
        }

        private string _ConvertTransferLogToLine(Client clientTo, decimal amount, string Username, string Separator = "#//#")
        {
            string Line = "";

            Line = DateTime.Now.ToString("g") + Separator;
            Line += this.AccountNum + Separator;
            Line += clientTo.AccountNum + Separator;
            Line += amount.ToString() + Separator;
            Line += (this.Balance - amount).ToString() + Separator;
            Line += (clientTo.Balance + amount).ToString() + Separator;
            Line += Username;

            return Line;
        }

        static private stTransferLog _ConvertLineToTransferLog(string Line, string Separator = "#//#")
        {
            string[] log = Line.Split(new string[] { Separator }, StringSplitOptions.None);

            stTransferLog TransferLog = new stTransferLog();

            TransferLog.transactionDateTime = Convert.ToDateTime(log[0]);
            TransferLog.accountFrom = log[1];
            TransferLog.accountTo = log[2];
            TransferLog.amount = Convert.ToDecimal(log[3]);
            TransferLog.BalanceFrom = Convert.ToDecimal(log[4]);
            TransferLog.BalanceTo = Convert.ToDecimal(log[5]);
            TransferLog.Username = log[6];

            return TransferLog;
        }

        static private void _AddLineToFile(string path, string Line)
        {
            File.AppendAllText(path, Line + Environment.NewLine);
        }

        static public List<Client> GetClientsData()
        {
            List<Client> clients = new List<Client>();

            foreach(string line in File.ReadLines("clients.txt"))
            {
                clients.Add(_ConvertLineToClient(line));
            }

            return clients;
        }

        static public List<stTransferLog> GetTransferLogs()
        {
            List<stTransferLog> transferLogs = new List<stTransferLog>();

            foreach(string line in File.ReadLines("TransferLogs.txt"))
            {
                transferLogs.Add(_ConvertLineToTransferLog(line));
            }

            return transferLogs;
        }

        static private void _SaveClientsDataToFile(List<Client> clients)
        {
            List<string> lines = new List<string>();

            foreach(Client client in clients)
            {
                if (client.isMarkedDeleted == false)
                {
                    lines.Add(_ConvertClientToLine(client));
                }
            }

            File.WriteAllLines("clients.txt", lines);
        }

        static public Client Find(string accountNumber)
        {
            List<Client> clients = GetClientsData();

            foreach (Client client in clients)
            {
                if (client.AccountNum == accountNumber)
                {
                    return client;
                }
            }

            return null;
        }

        public void Add()
        {
            _AddLineToFile("clients.txt", _ConvertClientToLine(this));
        }

        static public void Update(Client client)
        {
            List<Client> clients = GetClientsData();
            bool isUpdated = false;

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].AccountNum == client.AccountNum)
                {
                    clients[i] = client;
                    isUpdated = true;
                    break;
                }
            }

            if (isUpdated)
            {
                _SaveClientsDataToFile(clients);
            }
        }

        static public bool Delete(string accountNumber)
        {
            List<Client> clients = GetClientsData();

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].AccountNum == accountNumber)
                {
                    clients[i].isMarkedDeleted = true;
                    break;
                }
            }

            _SaveClientsDataToFile(clients);

            return true;
        }

        public bool Delete()
        {
            List<Client> clients = GetClientsData();

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].AccountNum == this.AccountNum)
                {
                    clients[i].isMarkedDeleted = true;
                    break;
                }
            }

            _SaveClientsDataToFile(clients);

            return true;
        }

        public bool Deposit(decimal amount)
        {
            List<Client> clients = GetClientsData();

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].AccountNum == this.AccountNum)
                {
                    clients[i].Balance += amount;
                    _SaveClientsDataToFile(clients);
                    return true;
                }
            }

            return false;
        }

        public bool Withdraw(decimal amount)
        {
            List<Client> clients = GetClientsData();

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].AccountNum == this.AccountNum && clients[i].Balance >= amount)
                {
                    clients[i].Balance -= amount;
                    _SaveClientsDataToFile(clients);
                    return true;
                }
            }

            return false;
        }

        public bool Transfer(decimal amount, Client transferTo, string Username)
        {
            if (this.Withdraw(amount) && transferTo.Deposit(amount))
            {
                _AddLineToFile("TransferLogs.txt", _ConvertTransferLogToLine(transferTo, amount, Username));
                return true;
            }
            return false;
        }

        public struct stTransferLog
        {
            public DateTime transactionDateTime;
            public string accountFrom;
            public string accountTo;
            public decimal BalanceFrom;
            public decimal BalanceTo;
            public decimal amount;
            public string Username;
        }

    }
}
