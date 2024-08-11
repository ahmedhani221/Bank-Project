using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Bank_Project
{
    public partial class ManageClients : Form
    {

        private string _currentUser;

        public ManageClients(string username)
        {
            InitializeComponent();
            _currentUser = username;
        }


        // Main Form

        private void ManageClients_Load(object sender, EventArgs e)
        { 
            lbldateTime.Text = DateTime.Now.ToString("D") + '\n' + DateTime.Now.ToString("t");
            UpdateNumOfClientsLabel();
            groupBox1.Text = _currentUser;
        }
        //
        ///////////Shared Between the whole form///////////
        //
        private void ClientTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tpAddClient || tabControl1.SelectedTab == tpUpdateClient)
            {
                TextBox textBox = sender as TextBox;

                if (String.IsNullOrEmpty(textBox.Text))
                {
                    e.Cancel = true;
                    textBox.Focus();
                    ClientInfoErrorProvider.SetError(textBox, "Required");
                }
                else
                {
                    e.Cancel = false;
                    ClientInfoErrorProvider.SetError(textBox, null);
                }
            }
            
        }

        private void ClientMaskedTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (tabControl1.SelectedTab == tpAddClient || tabControl1.SelectedTab == tpUpdateClient)
            {
                MaskedTextBox textBox = sender as MaskedTextBox;

                if (textBox.Text.Length < 14)
                {
                    e.Cancel = true;
                    textBox.Focus();
                    ClientInfoErrorProvider.SetError(textBox, "Required");
                }
                else
                {
                    e.Cancel = false;
                    ClientInfoErrorProvider.SetError(textBox, null);
                }

            }
        }

        private void UpdateNumOfClientsLabel()
        {
            lblNumOfClients.Text = ListViewClients.Items.Count + " Client(s) Found";
        }
        //
        ///////////Show Client Tab///////////
        //
        private void rbAscend_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAscend.Checked) // Ensure this is the correct radio button
            {
                ListViewClients.Sorting = SortOrder.Ascending;
                ListViewClients.Sort();  // Ensure this triggers the sort
            }
        }

        private void rbDescend_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDescend.Checked) // Ensure this is the correct radio button
            {
                ListViewClients.Sorting = SortOrder.Descending;
                ListViewClients.Sort();  // Ensure this triggers the sort
            }
        }
        //
        ///////////Add Client Tab///////////
        //
        private void ResetAddClientTab()
        {
            txtAddClientAccNo.Clear();
            txtAddClientPin.Clear();
            txtAddClientName.Clear();
            txtAddClientEmail.Clear();
            txtAddClientPhone.Clear();
            numAddClientBalance.Value = 0;
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to add this client", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                ListViewItem client = new ListViewItem(txtAddClientAccNo.Text.Trim());

                client.SubItems.Add(txtAddClientPin.Text.Trim());
                client.SubItems.Add(txtAddClientName.Text.Trim());
                client.SubItems.Add(txtAddClientEmail.Text.Trim());
                client.SubItems.Add(txtAddClientPhone.Text.Trim());
                client.SubItems.Add(numAddClientBalance.Text.Trim());

                ListViewClients.Items.Add(client);

                MessageBox.Show("Client Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetAddClientTab();

                UpdateNumOfClientsLabel();
            }
        }
    }
}
