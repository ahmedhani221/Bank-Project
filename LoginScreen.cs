using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_Project
{
    public partial class LoginScreen : Form
    {
        private byte trials = 3;

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            lbldateTime.Text = DateTime.Now.ToString("D") + '\n' + DateTime.Now.ToString("t");
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text == "Admin" && txtBoxPassword.Text == "ahmedHani221")
            {
                MessageBox.Show("Login Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainMenu mm = new MainMenu(txtBoxUsername.Text);
                mm.Show();

                // You might want to remove this if you're closing the form right after:
                // txtBoxUsername.Text = "";
                // txtBoxPassword.Text = "";

                //this.Hide();

                //// MainMenu's FormClosed event to close LoginScreen when MainMenu is closed
                //mm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                trials--;

                if (trials > 0)
                {
                    lblPasswordTrials.Text = "Invalid Username or Password\nYou have " + trials + " Attempt(s) left before locking your account";

                    txtBoxUsername.Text = "";
                    txtBoxPassword.Text = "";

                    txtBoxUsername.Focus();
                }
                else
                {
                    lblPasswordTrials.Text = "Your Account is Locked\nPlease Contact the admin to unlock your account";

                    txtBoxUsername.Enabled = false;
                    txtBoxPassword.Enabled = false;
                    btnLogin.Enabled = false;
                }
            }
        }

        
    }
}
