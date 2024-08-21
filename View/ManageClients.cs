using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CoreClassLib;

namespace Bank_Project
{
    public partial class ManageClients : Form
    {

        private User _CurrentUser;
        private List<Client> clients = Client.GetClientsData();

        public ManageClients(User user)
        {
            InitializeComponent();
            _CurrentUser = user;
        }

        private void ManageClients_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            lbldateTime.Text = $"{DateTime.Now:D}\n{DateTime.Now:t}";
            gbLayout.Text = _CurrentUser.Username;

            FillItemsWithClientsData();
            UpdateNumOfClientsLabel();
            ResetAllTabs();

            ListViewClients.Sorting = SortOrder.Ascending;
            ListViewClients.Sort();
        }

        private void FillItemsWithClientsData()
        {
            foreach (Client client in clients)
            {
                AddListViewItem(client);
                FillComboBoxItem(client);
            }
        }

        private void FillComboBoxItem(Client client)
        {
            cbUpdateClientAccNo.Items.Add(client.AccountNum);
        }

        private void AddListViewItem(Client client)
        {
            ListViewItem item = new ListViewItem(client.AccountNum)
            {
                SubItems = {
                    client.PinCode,
                    client.FullName,
                    client.Email,
                    client.Phone,
                    client.Balance.ToString()
                }
            };
            ListViewClients.Items.Add(item);
        }

        private void UpdateNumOfClientsLabel()
        {
            lblNumOfClients.Text = ListViewClients.Items.Count + " Client(s) Found";
        }

        private void ResetAllTabs()
        {
            ResetAddClientTab();
            ResetUpdateClientTab();
        }

        private void ClientTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (tabControlClients.SelectedTab == tpAddClient || tabControlClients.SelectedTab == tpUpdateClient)
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
            if (tabControlClients.SelectedTab == tpAddClient || tabControlClients.SelectedTab == tpUpdateClient)
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
        //
        ///////////Show Client Tab///////////
        //
        private void rbAscend_CheckedChanged(object sender, EventArgs e)
        {
            SetListViewSorting(SortOrder.Ascending);
        }

        private void rbDescend_CheckedChanged(object sender, EventArgs e)
        {
            SetListViewSorting(SortOrder.Descending);
        }

        private void SetListViewSorting(SortOrder order)
        {
            ListViewClients.Sorting = order;
            ListViewClients.Sort();
        }

        private void OpenTransactionScreen(short tabIndex, bool isWithdraw = false)
        {
            TransactionsScreen transactions = new TransactionsScreen(_CurrentUser, tabIndex, ListViewClients.SelectedItems[0].Text);

            if (isWithdraw)
            {
                transactions.rbWithdraw.Checked = true;
            }

            transactions.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTransactionScreen(0);
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTransactionScreen(0, true);
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTransactionScreen(1);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbUpdateClientAccNo.Text = ListViewClients.SelectedItems[0].Text;
            tabControlClients.SelectedTab = tpUpdateClient;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem SelectedItem = ListViewClients.SelectedItems[0];

            if (SelectedItem != null && Client.Delete(SelectedItem.Text))
            {
                ListViewClients.Items.Clear();
                FillItemsWithClientsData();
                UpdateNumOfClientsLabel();

            }
        }

        private void txtBoxClientSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBoxClientSearch.Text.Trim();

            // Clear the list view
            ListViewClients.Items.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                // If the search box is empty, refill the list view with all clients
                foreach (Client client in clients)
                {
                    AddListViewItem(client);
                }
            }
            else
            {
                // Filter and add items that match the search text
                foreach (Client client in clients)
                {
                    if (client.AccountNum.ToLower().Contains(searchText.ToLower()))
                    {
                        AddListViewItem(client);
                    }
                }
            }

            UpdateNumOfClientsLabel(); // Update the number of clients found
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
            btnAddNewClient.Enabled = false;
        }

        private void ValidateAddClientForm()
        {
            bool isValid = !string.IsNullOrWhiteSpace(txtAddClientAccNo.Text) &&
                           !string.IsNullOrWhiteSpace(txtAddClientPin.Text) &&
                           !string.IsNullOrWhiteSpace(txtAddClientName.Text) &&
                           !string.IsNullOrWhiteSpace(txtAddClientEmail.Text) &&
                           !string.IsNullOrWhiteSpace(txtAddClientPhone.Text) &&
                           numAddClientBalance.Value > 0 &&
                           ClientInfoErrorProvider.GetError(txtAddClientAccNo) == "" &&
                           ClientInfoErrorProvider.GetError(txtAddClientPin) == "" &&
                           ClientInfoErrorProvider.GetError(txtAddClientName) == "" &&
                           ClientInfoErrorProvider.GetError(txtAddClientEmail) == "" &&
                           ClientInfoErrorProvider.GetError(txtAddClientPhone) == "";

            btnAddNewClient.Enabled = isValid;
        }

        private void txtAddClientAccNo_TextChanged(object sender, EventArgs e)
        {
            bool accountExists = false;

            foreach (ListViewItem item in ListViewClients.Items)
            {
                if (txtAddClientAccNo.Text.Trim() == item.Text)
                {
                    accountExists = true;
                    break;
                }
            }

            if (accountExists)
            {
                ClientInfoErrorProvider.SetError(txtAddClientAccNo, "Account Number Already Exists");
            }
            else
            {
                ClientInfoErrorProvider.SetError(txtAddClientAccNo, "");
            }

            ValidateAddClientForm();
        }

        private void txtAddClientPin_TextChanged(object sender, EventArgs e)
        {
            ValidateAddClientForm();
        }

        private void txtAddClientName_TextChanged(object sender, EventArgs e)
        {
            ValidateAddClientForm();
        }

        private void txtAddClientEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtAddClientEmail.Text.Contains("@gmail.com"))
            {
                ClientInfoErrorProvider.SetError(txtAddClientEmail, "Email must contain @gmail.com");
            }
            else
            {
                ClientInfoErrorProvider.SetError(txtAddClientEmail, "");
            }

            ValidateAddClientForm();
        }

        private void txtAddClientPhone_TextChanged(object sender, EventArgs e)
        {
            ValidateAddClientForm();
        }

        private void numAddClientBalance_ValueChanged(object sender, EventArgs e)
        {
            ValidateAddClientForm();
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to add this client", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] nameParts = txtAddClientName.Text.Trim().Split(' ');

                if (nameParts.Length < 2)
                {
                    MessageBox.Show("Please enter both first and last names.");
                    return;
                }

                string firstName = nameParts[0];
                string lastName = nameParts[1];

                Client client = new Client(
                    txtAddClientAccNo.Text.Trim(),
                    txtAddClientPin.Text.Trim(),
                    firstName,
                    lastName,
                    txtAddClientEmail.Text.Trim(),
                    txtAddClientPhone.Text.Trim(),
                    Convert.ToDecimal(numAddClientBalance.Value)
                );


                try
                {
                    client.Add();  // Ensure that the Add method is public and correctly implemented
                    AddListViewItem(client);
                    FillComboBoxItem(client);
                    MessageBox.Show("Client Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAddClientTab();
                    UpdateNumOfClientsLabel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //
        ///////////Update Client Tab///////////
        //
        private void ResetUpdateClientTab()
        {
            txtUpdateClientEmail.Enabled = false;
            txtUpdateClientName.Enabled = false;
            txtUpdateClientPin.Enabled = false;
            maskedTxtUpdateClientPhone.Enabled = false;
            numUpdateClientBalance.Enabled = false;
            btnUpdate.Enabled = false;

            cbUpdateClientAccNo.SelectedItem = null;
            txtUpdateClientPin.Clear();
            txtUpdateClientName.Clear();
            txtUpdateClientEmail.Clear();
            maskedTxtUpdateClientPhone.Clear();
            numUpdateClientBalance.Value = 0;
        }

        private void UpdateItem(Client client)
        {
            foreach(ListViewItem item in ListViewClients.Items)
            {
                if(item.Text == client.AccountNum)
                {
                    item.Text = client.AccountNum;
                    item.SubItems[1].Text = client.PinCode;
                    item.SubItems[2].Text = client.FullName;
                    item.SubItems[3].Text = client.Email;
                    item.SubItems[4].Text = client.Phone;
                    item.SubItems[5].Text = client.Balance.ToString();
                    break;
                }
            }
        }

        private void cbUpdateClientAccNo_SelectedValueChanged(object sender, EventArgs e)
        {
            Client selectedClient = Client.Find(cbUpdateClientAccNo.Text);

            if (selectedClient != null)
            {
                txtUpdateClientEmail.Enabled = true;
                txtUpdateClientName.Enabled = true;
                txtUpdateClientPin.Enabled = true;
                maskedTxtUpdateClientPhone.Enabled = true;
                numUpdateClientBalance.Enabled = true;
                btnUpdate.Enabled = true;

                txtUpdateClientPin.Text = selectedClient.PinCode;
                txtUpdateClientName.Text = selectedClient.FullName;
                txtUpdateClientEmail.Text = selectedClient.Email;
                maskedTxtUpdateClientPhone.Text = selectedClient.Phone;
                numUpdateClientBalance.Value = selectedClient.Balance;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this client", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] nameParts = txtUpdateClientName.Text.Trim().Split(' ');

                if (nameParts.Length < 2)
                {
                    MessageBox.Show("Please enter both first and last names.");
                    return;
                }

                string firstName = nameParts[0];
                string lastName = nameParts[1];

                try
                {
                    Client selectedClient = Client.Find(cbUpdateClientAccNo.Text.Trim());

                    selectedClient.AccountNum = cbUpdateClientAccNo.Text;
                    selectedClient.PinCode = txtUpdateClientPin.Text;
                    selectedClient.FirstName = firstName;
                    selectedClient.LastName = lastName;
                    selectedClient.Email = txtUpdateClientEmail.Text;
                    selectedClient.Phone = maskedTxtUpdateClientPhone.Text;
                    selectedClient.Balance = Convert.ToDecimal(numUpdateClientBalance.Value);

                    Client.Update(selectedClient);
                    UpdateItem(selectedClient);
                    ResetUpdateClientTab();
                    MessageBox.Show("Client updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUpdateClientEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtUpdateClientEmail.Text.Contains("@gmail.com"))
            {
                ClientInfoErrorProvider.SetError(txtUpdateClientEmail, "Email must contain @gmail.com");
            }
            else
            {
                ClientInfoErrorProvider.SetError(txtUpdateClientEmail, "");
            }
        }
    }
}
