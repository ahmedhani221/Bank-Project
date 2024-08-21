using CoreClassLib;
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
        private User _CurrentUser;

        public MainMenu(User user)
        {
            InitializeComponent();
            _CurrentUser = user;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lbldateTime.Text = DateTime.Now.ToString("D") + '\n' + DateTime.Now.ToString("t");
            gbLayout.Text = _CurrentUser.Username;
            title.Text += _CurrentUser.FullName;

            CheckPermissions();
        }

        private void SetButtonVisibility(Button button)
        {
            button.Visible = User.CheckPermission(_CurrentUser, Convert.ToInt16(button.Tag));
        }

        private void CheckPermissions()
        {
            if (_CurrentUser.Permission == -1)
            {
                btnManageClients.Visible = true;
                btnManageUsers.Visible = true;
                btnTransactions.Visible = true;
                btnExchange.Visible = true;
            }
            else
            {
                SetButtonVisibility(btnManageClients);
                SetButtonVisibility(btnManageUsers);
                SetButtonVisibility(btnTransactions);
                SetButtonVisibility(btnExchange);
            }
        }


        private void btnManageClients_Click(object sender, EventArgs e)
        {
            ManageClients manageClients = new ManageClients(_CurrentUser);
            manageClients.ShowDialog();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            ManageUsers users = new ManageUsers(_CurrentUser);
            users.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionsScreen transactions = new TransactionsScreen(_CurrentUser);
            transactions.ShowDialog();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            CurrencyExchange exchange = new CurrencyExchange(_CurrentUser);
            exchange.ShowDialog();
        }
    }
}
