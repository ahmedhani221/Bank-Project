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
    public partial class TransactionsScreen : Form
    {
        private string _currentUser;

        public TransactionsScreen(string currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void TrasactionsScreen_Load(object sender, EventArgs e)
        {
            lbldateTime.Text = DateTime.Now.ToString("D") + '\n' + DateTime.Now.ToString("t");
            groupBox1.Text = _currentUser;
        }

        private void rbDeposit_CheckedChanged(object sender, EventArgs e)
        {
            btnAddNewClient.Text = rbDeposit.Text;
        }

        private void rbWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            btnAddNewClient.Text = rbWithdraw.Text;
        }
    }
}
