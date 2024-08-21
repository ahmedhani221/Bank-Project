using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CoreClassLib;

namespace Bank_Project
{
    public partial class TransactionsScreen : Form
    {
        private User _CurrentUser;

        private Client _Client;
        private Client _transferFromClient;
        private Client _transferToClient;

        private List<Client> clients = Client.GetClientsData();
        private List<Client.stTransferLog> transferLogs = Client.GetTransferLogs();

        public TransactionsScreen(User user)
        {
            InitializeComponent();
            ResetAllTabs();
            _CurrentUser = user;
        }

        public TransactionsScreen(User user, short tabIndex, string accountNum)
        {
            InitializeComponent();
            _CurrentUser = user;
            _Client = Client.Find(accountNum);

            tabControlTransaction.SelectedIndex = tabIndex;

            switch (tabIndex)
            {
                case 0:
                    cbTransactionAccNo.Text = _Client.AccountNum;
                    FillLblBalance(_Client);
                    break;
                case 1:
                    cbTransferFromAccNo.Text = _Client.AccountNum;
                    FillLblTransferFromBalance(_Client);
                    break;
            }
        }
        //
        ///////////Load and Intialization Methods///////////
        //
        private void TrasactionsScreen_Load(object sender, EventArgs e)
        {
            IntializeForm();
        }

        private void IntializeForm()
        {
            lbldateTime.Text = $"{DateTime.Now:D}\n{DateTime.Now:t}";
            gbLayout.Text = _CurrentUser.Username;

            FillLblTotalBalance();
            FillItemsWithClientsData();
            UpdateNumOfClientsLabel();
            FillListViewWithLogs();
            UpdateNumOfTransferLogsLabel();
        }

        private void FillItemsWithClientsData()
        {
            foreach (Client client in clients)
            {
                AddListViewItem(client);
                FillComboBoxesItem(client);
            }
        }

        private void FillListViewWithLogs()
        {
            foreach (Client.stTransferLog transferLog in transferLogs)
            {
                AddTransferListViewItem(transferLog);
            }
        }
        //
        ///////////Shared///////////
        //
        private void numAmount_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;

            if (num.Value < 1)
            {
                errorProviderTransaction.SetError(num, "Amount Must be Greater Than $0");
            }
            else
            {
                errorProviderTransaction.SetError(num, "");
            }
        }

        private void cbTransferToAccNo_Validating(object sender, CancelEventArgs e)
        {
            if (cbTransferFromAccNo.Text == cbTransferToAccNo.Text && cbTransferToAccNo.Text != "")
            {
                errorProviderTransaction.SetError(cbTransferToAccNo, "Can't Transfer to the same account!");
                e.Cancel = true;
            }
            else
            {
                errorProviderTransaction.SetError(cbTransferToAccNo, "");
                e.Cancel = false;
            }
        }

        private void UpdateNumOfClientsLabel()
        {
            lblNumOfClientBalances.Text = ListViewBalances.Items.Count + " Client(s) Found";
        }

        private void UpdateNumOfTransferLogsLabel()
        {
            lblTransferLogs.Text = listViewTransferLog.Items.Count + " Transfer(s) Found";
        }

        private void AddListViewItem(Client client)
        {
            ListViewItem item = new ListViewItem(client.AccountNum);

            item.SubItems.Add(client.FullName);
            item.SubItems.Add(client.Balance.ToString());

            ListViewBalances.Items.Add(item);
        }

        private void FillComboBoxesItem(Client client)
        {
            cbTransactionAccNo.Items.Add(client.AccountNum);
            cbTransferFromAccNo.Items.Add(client.AccountNum);
            cbTransferToAccNo.Items.Add(client.AccountNum);

        }

        private void FillLblBalance(Client client)
        {
            lblBalance.Text = client.Balance.ToString() + "EGP";
        }

        private void FillLblTransferFromBalance(Client client)
        {
            lblTransferFromBalance.Text = client.Balance + "EGP";
        }

        private void UpdateItem(Client client)
        {
            foreach (ListViewItem item in ListViewBalances.Items)
            {
                if (item.Text == client.AccountNum)
                {
                    item.SubItems[1].Text = client.FullName;
                    item.SubItems[2].Text = client.Balance.ToString();
                    break;
                }
            }
            ListViewBalances.Update();
        }

        private void ResetAllTabs()
        {
            ResetDepositWithdrawTab();
            ResetTransferTab();
        }
        //
        ///////////Deposit / Withdraw Tab///////////
        //
        private void ResetDepositWithdrawTab()
        {
            cbTransactionAccNo.Text = null;
            lblBalance.ResetText();
            lblBalance.Visible = false;
            numTransaction.Value = 0;
            lblTransactionCurrentBalance.Visible = false;
            numTransaction.Enabled = false;
            btnTransaction.Enabled= false; 
        }

        private void rbDeposit_CheckedChanged(object sender, EventArgs e)
        {
            btnTransaction.Text = rbDeposit.Text;
        }

        private void rbWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            btnTransaction.Text = rbWithdraw.Text;
            
        }

        private void cbTransactionAccNo_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (!String.IsNullOrEmpty(cbTransactionAccNo.Text))
            {
                _Client = Client.Find(cbTransactionAccNo.Text);
                FillLblBalance(_Client);
                lblBalance.Visible = true;
                lblTransactionCurrentBalance.Visible = true;
                numTransaction.Enabled = true;
                btnTransaction.Enabled = true;
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            string action = rbDeposit.Checked ? "deposit" : "withdraw";
            decimal amount = numTransaction.Value;
            bool isConfirmed = MessageBox.Show($"Are you sure you want to {action} {amount} EGP?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (!isConfirmed)
            {
                MessageBox.Show($"{action} canceled", "", MessageBoxButtons.OK);
                return;
            }

            bool success = rbDeposit.Checked ? _Client.Deposit(amount) : _Client.Withdraw(amount);

            if (success)
            {
                MessageBox.Show($"Amount has been {action}ed ({amount} EGP) successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clients = Client.GetClientsData();
                ListViewBalances.Items.Clear();
                foreach (Client client in clients)
                {
                    AddListViewItem(client);
                    FillComboBoxesItem(client);
                }

                ResetDepositWithdrawTab();
            }

            else if (rbWithdraw.Checked)
            {
                errorProviderTransaction.SetError(numTransaction, "Insufficient Balance");
            }
        }
        //
        ///////////Transfer Tab///////////
        //
        private void ResetTransferTab()
        {
            cbTransferFromAccNo.Text = null;
            cbTransferToAccNo.Text = null;
            lblTransferFromBalance.ResetText();
            lblTransferToBalance.ResetText();
            lblTransferFromBalance.Visible = false;
            lblTransferToBalance.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            numTransfer.Value = 0;
            numTransfer.Enabled = false;
            btnTransfer.Enabled = false;
        }

        private void cbTransferFromAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbTransferFromAccNo.Text))
            {
                _transferFromClient = Client.Find(cbTransferFromAccNo.Text);
                lblTransferFromBalance.Text = _transferFromClient.Balance + "EGP";
                lblTransferFromBalance.Visible = true;
                label5.Visible = true;
                numTransfer.Enabled = true;
                if (cbTransferToAccNo.Text != null) btnTransfer.Enabled = true;
            }
        }

        private void cbTransferToAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbTransferToAccNo.Text))
            {
                _transferToClient = Client.Find(cbTransferToAccNo.Text);
                lblTransferToBalance.Text = _transferToClient.Balance + "EGP";
                lblTransferToBalance.Visible = true;
                label6.Visible = true;
                if (cbTransferFromAccNo.Text != null) btnTransfer.Enabled = true;
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (_transferFromClient == null) _transferFromClient = Client.Find(cbTransferFromAccNo.Text);
            if (_transferToClient == null) _transferToClient = Client.Find(cbTransferToAccNo.Text);

            decimal amount = numTransfer.Value;
            bool isConfirmed = (MessageBox.Show($"Are you want to transfer {amount} EGP?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);

            if (!isConfirmed)
            {
                MessageBox.Show($"Transfer canceled", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                bool success = _transferFromClient.Transfer(amount, _transferToClient, _CurrentUser.Username);

                if (success)
                {
                    MessageBox.Show($"Amount has been Transferred ({amount} EGP) successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateItem(_transferFromClient);
                    UpdateItem(_transferToClient);
                    AddTransferListViewItem();
                    UpdateNumOfTransferLogsLabel();
                    ResetTransferTab();
                }
                else
                {
                    errorProviderTransaction.SetError(numTransfer, "Insufficient Balance");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        ///////////Total Balances Tab///////////
        //
        private void FillLblTotalBalance()
        {
            decimal totalBalance = 0;
            foreach (Client client in clients)
            {
                totalBalance += client.Balance;
            }

            lblTotalBalancesNumber.Text = $"Total Balance: ({totalBalance} EGP)";
            lblTotalBalancesWord.Text = $"({totalBalance}) Egyptian Pound";
        }

        private void rbAscend_CheckedChanged(object sender, EventArgs e)
        {
            ListViewBalances.Sorting = SortOrder.Ascending;
            ListViewBalances.Sort();
        }

        private void rbDescend_CheckedChanged(object sender, EventArgs e)
        {
            ListViewBalances.Sorting = SortOrder.Descending;
            ListViewBalances.Sort();
        }

        private void txtSearchBalances_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBalances.Text.Trim();

            // Clear the list view
            ListViewBalances.Items.Clear();

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
        ///////////Transfer Logs Tab///////////
        //
        private void rbAscendLogs_CheckedChanged(object sender, EventArgs e)
        {
            listViewTransferLog.Sorting = SortOrder.Ascending;
            listViewTransferLog.Sort();
        }

        private void rbDescendLogs_CheckedChanged(object sender, EventArgs e)
        {
            listViewTransferLog.Sorting = SortOrder.Descending;
            listViewTransferLog.Sort();
        }

        private void AddTransferListViewItem(Client.stTransferLog transferLog)
        {
            ListViewItem item = new ListViewItem(transferLog.transactionDateTime.ToString());
            item.SubItems.Add(transferLog.accountFrom);
            item.SubItems.Add(transferLog.accountTo);
            item.SubItems.Add(transferLog.amount.ToString());
            item.SubItems.Add(transferLog.BalanceFrom.ToString());
            item.SubItems.Add(transferLog.BalanceTo.ToString());
            item.SubItems.Add(transferLog.Username);

            listViewTransferLog.Items.Add(item);
        }

        private void AddTransferListViewItem()
        {
            listViewTransferLog.Items.Clear();

            transferLogs = Client.GetTransferLogs();

            foreach (Client.stTransferLog transferLog in transferLogs)
            {
                AddTransferListViewItem(transferLog);
            }
        }

        private void txtSearchLogs_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchLogs.Text.Trim();

            // Clear the list view
            listViewTransferLog.Items.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                // If the search box is empty, refill the list view with all logs
                foreach (Client.stTransferLog log in transferLogs)
                {
                    AddTransferListViewItem(log);
                }
            }
            else
            {
                // Filter and add items that match the search text
                foreach (Client.stTransferLog log in transferLogs)
                {
                    if (log.accountFrom.ToLower().Contains(searchText.ToLower()) || log.accountTo.ToLower().Contains(searchText.ToLower()))
                    {
                        AddTransferListViewItem(log);
                    }
                }
            }

            UpdateNumOfTransferLogsLabel(); // Update the number of logs found
        }
    }
}
