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
    public partial class CurrencyExchange : Form
    {
        private string _currentUser;

        public CurrencyExchange(string currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void CurrencyExchange_Load(object sender, EventArgs e)
        {
            lbldateTime.Text = DateTime.Now.ToString("D") + '\n' + DateTime.Now.ToString("t");
            groupBox1.Text = _currentUser;
        }
    }
}
