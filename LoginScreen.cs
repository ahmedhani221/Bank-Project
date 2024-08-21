using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;
using CoreClassLib;

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

        private void ResetLoginScreen()
        {
            txtBoxUsername.Text = "";
            txtBoxPassword.Text = "";
            lblPasswordTrials.Text = "";

            txtBoxUsername.Focus();

            trials = 3;
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (String.IsNullOrEmpty(textBox.Text))
            {
                errorProviderLoginScreen.SetError(textBox, "Required");
            }
            else
            {
                errorProviderLoginScreen.SetError(textBox, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = User.Find(txtBoxUsername.Text, txtBoxPassword.Text);
                if (user != null)
                {
                    MainMenu mm = new MainMenu(user);

                    ResetLoginScreen();

                    mm.Show();
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
                        ResetLoginScreen();

                        lblPasswordTrials.Text = "Your Account is Locked\nPlease Contact the admin to unlock your account";

                        txtBoxUsername.Enabled = false;
                        txtBoxPassword.Enabled = false;
                        btnLogin.Enabled = false;
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"An error occurred while login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
