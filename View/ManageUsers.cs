using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CoreClassLib;

namespace Bank_Project
{
    public partial class ManageUsers : Form
    {
        private User _CurrentUser;
        List<User> _Users = User.GetUsersData();

        public ManageUsers(User user)
        {
            InitializeComponent();
            _CurrentUser = user;
        }
        //
        ///////////Main Form///////////
        //
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            InitializeForm();   
        }

        private void InitializeForm()
        {
            lbldateTime.Text = lbldateTime.Text = $"{DateTime.Now:D}\n{DateTime.Now:t}"; ;
            gbLayout.Text = _CurrentUser.Username;

            FillItemsWithUsersData();
            UpdateNumOfUsersLabel();
        } 

        private void FillItemsWithUsersData()
        {
            foreach (User user in _Users)
            {
                AddListViewItem(user);
                FillComboBox(user);
            }
        }
        //
        ///////////Shared///////////
        //
        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (String.IsNullOrEmpty(textBox.Text))
            {
                errorProviderUsers.SetError(textBox, "Required");
            }
            else
            {
                errorProviderUsers.SetError(textBox, null);
            }
        }

        private void AddListViewItem(User user)
        {
            ListViewItem item = new ListViewItem(user.Username);
            item.SubItems.Add(user.Password);
            item.SubItems.Add(user.FullName);
            item.SubItems.Add(user.Email);
            item.SubItems.Add(user.Phone);
            item.SubItems.Add(user.Permission.ToString());

            ListViewUsers.Items.Add(item);
        }

        private void FillComboBox(User user)
        {
            cbUpdateUsername.Items.Add(user.Username);
        }

        private string GenerateUsername()
        {
            return "User" + (ListViewUsers.Items.Count);
        }

        private short ReadAddPermission()
        {
            short permission = 0;

            if (rbYes1.Checked) return -1;

            if (ChkManageClient1.Checked) permission |= 1;
            if (ChkManageUser1.Checked) permission |= 2;
            if (ChkTransactions1.Checked) permission |= 4;
            if (ChkCurrency1.Checked) permission |= 8;

            return permission;
        }

        private short ReadUpdatePermission()
        {
            short permission = 0;

            if (rbYes2.Checked)
            {
                return -1;
            }

            if (ChkManageClient2.Checked) permission |= 1;
            if (ChkManageUser2.Checked) permission |= 2;
            if (ChkTransactions2.Checked) permission |= 4;
            if (ChkCurrency2.Checked) permission |= 8;

            return permission;
        }

        //
        ///////////Show Users Tab///////////
        //
        private void UpdateNumOfUsersLabel()
        {
            lblNumOfUsers.Text = ListViewUsers.Items.Count + " User(s) Found";
        }

        private void rbAscend_CheckedChanged(object sender, EventArgs e)
        {
            ListViewUsers.Sorting = SortOrder.Ascending;
        }

        private void rbDescend_CheckedChanged(object sender, EventArgs e)
        {
            ListViewUsers.Sorting = SortOrder.Descending;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbUpdateUsername.Text = ListViewUsers.SelectedItems[0].Text;
            tabControlUsers.SelectedTab = tpUpdateUser;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem SelectedItem = ListViewUsers.SelectedItems[0];
            User user = User.Find(ListViewUsers.SelectedItems[0].Text);

            if (SelectedItem != null && user.Delete())
            {
                ListViewUsers.Items.Clear();
                FillItemsWithUsersData();
                UpdateNumOfUsersLabel();
            }
        }

        private void txtSearchByUsername_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchByUsername.Text.Trim();

            // Clear the list view
            ListViewUsers.Items.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                // If the search box is empty, refill the list view with all users
                foreach (User user in _Users)
                {
                    AddListViewItem(user);
                }
            }
            else
            {
                // Filter and add items that match the search text
                foreach (User user in _Users)
                {
                    if (user.Username.ToLower().Contains(searchText.ToLower()))
                    {
                        AddListViewItem(user);
                    }
                }
            }

            UpdateNumOfUsersLabel(); // Update the number of users found
        }
        //
        ///////////Add User Tab///////////
        //
        private void ResetAddUserTab()
        {
            txtAddName.Clear();
            txtAddEmail.Clear();
            txtAddPassword.Clear();
            txtAddPhone.Clear();

            rbYes1.Checked = true;
            ChkManageClient1.Checked = false;
            ChkManageUser1.Checked = false;
            ChkTransactions1.Checked = false;
            ChkCurrency1.Checked = false;
        }

        private void rbYes1_CheckedChanged(object sender, EventArgs e)
        {
            ChkManageClient1.Enabled = false;
            ChkManageUser1.Enabled = false;
            ChkTransactions1.Enabled = false;
            ChkCurrency1.Enabled = false;
        }

        private void rbNo1_CheckedChanged(object sender, EventArgs e)
        {
            ChkManageClient1.Enabled = true;
            ChkManageUser1.Enabled = true;
            ChkTransactions1.Enabled = true;
            ChkCurrency1.Enabled = true;
        }

        private void txtAddEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtAddEmail.Text.Contains("@gmail.com"))
            {
                errorProviderUsers.SetError(txtAddEmail, "Email must contain @gmail.com");
            }
            else
            {
                errorProviderUsers.SetError(txtAddEmail, "");
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this User", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] nameParts = txtAddName.Text.Trim().Split(' ');

                if (nameParts.Length < 2)
                {
                    MessageBox.Show("Please enter both first and last names.");
                    return;
                }

                string firstName = nameParts[0];
                string lastName = nameParts[1];

                User user = new User(GenerateUsername(), 
                    txtAddPassword.Text, 
                    firstName, lastName, 
                    txtAddEmail.Text, 
                    txtAddPhone.Text, 
                    ReadAddPermission());

                try
                {
                    user.Add();
                    AddListViewItem(user);
                    FillComboBox(user);
                    MessageBox.Show("User Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAddUserTab();
                    UpdateNumOfUsersLabel();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the User: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //
        ///////////Update User Tab///////////
        //
        private void ResetUpdateUserTab()
        {
            cbUpdateUsername.Text = null;
            txtUpdateEmail.Clear();
            txtUpdateFirstName.Clear();
            txtUpdateLastName.Clear();
            txtUpdatePassword.Clear();
            txtUpdatePhone.Clear();

            txtUpdateEmail.Enabled = false;
            txtUpdateFirstName.Enabled = false;
            txtUpdateLastName.Enabled = false;
            txtUpdatePassword.Enabled = false;
            txtUpdatePhone.Enabled = false;

            rbYes2.Checked = true;
            ChkManageClient2.Checked = false;
            ChkManageUser2.Checked = false;
            ChkTransactions2.Checked = false;
            ChkCurrency2.Checked = false;
        }

        private void rbYes2_CheckedChanged(object sender, EventArgs e)
        {
            ChkManageClient2.Enabled = false;
            ChkManageUser2.Enabled = false;
            ChkTransactions2.Enabled = false;
            ChkCurrency2.Enabled = false;
        }

        private void rbNo2_CheckedChanged(object sender, EventArgs e)
        {
            ChkManageClient2.Enabled = true;
            ChkManageUser2.Enabled = true;
            ChkTransactions2.Enabled = true;
            ChkCurrency2.Enabled = true;
        }

        private void UpdateItem(User user)
        {
            foreach (ListViewItem item in ListViewUsers.Items)
            {
                if (item.Text == user.Username)
                {
                    item.Text = user.Username;
                    item.SubItems[1].Text = user.Password;
                    item.SubItems[2].Text = user.FullName;
                    item.SubItems[3].Text = user.Email;
                    item.SubItems[4].Text = user.Phone;
                    item.SubItems[5].Text = user.Permission.ToString();
                    break;
                }
            }
        }

        private void cbUpdateUsername_SelectedValueChanged(object sender, EventArgs e)
        {
            User SelectedUser = null;

            if (cbUpdateUsername.Text != null)
            {
                SelectedUser = User.Find(cbUpdateUsername.Text);
            }

            if (SelectedUser != null)
            {
                txtUpdateEmail.Enabled = true;
                txtUpdateFirstName.Enabled = true;
                txtUpdateLastName.Enabled = true;
                txtUpdatePassword.Enabled = true;
                txtUpdatePhone.Enabled = true;

                txtUpdateEmail.Text = SelectedUser.Email;
                txtUpdateFirstName.Text = SelectedUser.FirstName;
                txtUpdateLastName.Text = SelectedUser.LastName;
                txtUpdatePassword.Text = SelectedUser.Password;
                txtUpdatePhone.Text = SelectedUser.Phone;
            }
        }

        private void txtUpdateEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtUpdateEmail.Text.Contains("@gmail.com"))
            {
                errorProviderUsers.SetError(txtUpdateEmail, "Email must contain @gmail.com");
            }
            else
            {
                errorProviderUsers.SetError(txtUpdateEmail, "");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this user", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    User selectedUser = User.Find(cbUpdateUsername.Text.Trim());

                    selectedUser.Username = cbUpdateUsername.Text;
                    selectedUser.Password = txtUpdatePassword.Text;
                    selectedUser.FirstName = txtUpdateFirstName.Text;
                    selectedUser.LastName = txtUpdateLastName.Text;
                    selectedUser.Email = txtUpdateEmail.Text;
                    selectedUser.Phone = txtUpdatePhone.Text;
                    selectedUser.Permission = ReadUpdatePermission();

                    selectedUser.Update();
                    UpdateItem(selectedUser);
                    ResetUpdateUserTab();
                    MessageBox.Show("User updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
