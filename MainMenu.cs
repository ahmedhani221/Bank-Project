using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public partial class MainMenu : Form
    {
        private string _currentUser;

        public MainMenu(string Username)
        {
            InitializeComponent();
            _currentUser = Username;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lbldateTime.Text = DateTime.Now.ToString("D") + '\n' + DateTime.Now.ToString("t");
            groupBox1.Text = _currentUser;
            title.Text += "Ahmed Hani";
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers(_currentUser);
            users.ShowDialog();
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            ManageClients manageClients = new ManageClients(_currentUser);
            manageClients.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionsScreen transactions = new TransactionsScreen(_currentUser);
            transactions.ShowDialog();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            CurrencyExchange exchange = new CurrencyExchange(_currentUser);
            exchange.ShowDialog();
        }
    }
}
