using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreClassLib;

namespace Bank_Project
{
    public partial class CurrencyExchange : Form
    {
        private User _CurrentUser;
        private List<Currency> currencies = Currency.GetCurrenciesData();
        private Currency _Currency;
        private Currency _ConvertFrom;
        private Currency _ConvertTo;

        public CurrencyExchange(User user)
        {
            InitializeComponent();
            _CurrentUser = user;
        }

        private void CurrencyExchange_Load(object sender, EventArgs e)
        {
            lbldateTime.Text = DateTime.Now.ToString("D") + '\n' + DateTime.Now.ToString("t");
            gbLayout.Text = _CurrentUser.Username;

            ResetAllTabs();

            foreach (Currency currency in currencies)
            {
                AddListViewItem(currency);
                FillComboBoxes(currency);
            }

            UpdateCurrencieslbl();
        }
        //
        ///////////Shared///////////
        //
        private void AddListViewItem(Currency currency)
        {
            ListViewItem item = new ListViewItem(currency.CountryName);
            item.SubItems.Add(currency.CurrencyCode);
            item.SubItems.Add(currency.CurrencyName);
            item.SubItems.Add(currency.Rate.ToString());

            ListViewCurrencies.Items.Add(item);
        }

        private void FillComboBoxes(Currency currency)
        {
            cbCountryName.Items.Add(currency.CountryName);
            cbConvertFrom.Items.Add(currency.CountryName);
            cbConvertTo.Items.Add(currency.CountryName);
        }

        private void UpdateLblCurrencyData(Currency currency)
        {
            lblCurrencyData.Text = $"Country: {currency.CountryName}" +
                $"\nCode: {currency.CurrencyCode}" +
                $"\nCurrency Name: {currency.CurrencyName}" +
                $"\nRate({currency.Rate}/$)";
        }

        private void UpdateLblConvertFrom(Currency currency)
        {
            lblConvertFromData.Text = $"Country: {_ConvertFrom.CountryName}" +
                $"\nCode: {_ConvertFrom.CurrencyCode}" +
                $"\nCurrency Name: {_ConvertFrom.CurrencyName}" +
                $"\nRate({_ConvertFrom.Rate}/$)";
        }

        private void UpdateLblConvertTo(Currency currency)
        {
            lblConvertToData.Text = $"Country: {_ConvertTo.CountryName}" +
                $"\nCode: {_ConvertTo.CurrencyCode}" +
                $"\nCurrency Name: {_ConvertTo.CurrencyName}" +
                $"\nRate({_ConvertTo.Rate}/$)";
        }

        private void UpdateItem(Currency currency)
        {
            foreach (ListViewItem item in ListViewCurrencies.Items)
            {
                if (item.Text == currency.CountryName)
                {
                    item.SubItems[3].Text = currency.Rate.ToString();
                    break;
                }
            }
        }

        private void ResetAllTabs()
        {
            ResetUpdateRate();
            ResetCalculator();
        }
        //
        ///////////Show Currencies Tab///////////
        //
        private void rbAscend_CheckedChanged(object sender, EventArgs e)
        {
            ListViewCurrencies.Sorting = SortOrder.Ascending;
        }

        private void rbDescend_CheckedChanged(object sender, EventArgs e)
        {
            ListViewCurrencies.Sorting = SortOrder.Descending;
        }

        private void UpdateCurrencieslbl()
        {
            if (ListViewCurrencies.Items.Count > 1) lblNumOfCurrencies.Text = ListViewCurrencies.Items.Count.ToString() + " Currencies Found";
            else lblNumOfCurrencies.Text = ListViewCurrencies.Items.Count.ToString() + " Currency Found";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            // Clear the list view
            ListViewCurrencies.Items.Clear();

            if (string.IsNullOrEmpty(searchText))
            {
                // If the search box is empty, refill the list view with all currencies
                foreach (Currency currency in currencies)
                {
                    AddListViewItem(currency);
                }
            }
            else
            {
                // Filter and add items that match the search text
                foreach (Currency currency in currencies)
                {
                    if (currency.CountryName.ToLower().Contains(searchText.ToLower()) || currency.CurrencyCode.ToLower().Contains(searchText.ToLower()))
                    {
                        AddListViewItem(currency);
                    }
                }
            }

            UpdateCurrencieslbl(); // Update the number of currency found
        }
        //
        ///////////Update Rate Tab///////////
        //
        private void ResetUpdateRate()
        {
            cbCountryName.ResetText();
            lblCurrencyData.ResetText();
            btnUpdate.Enabled = false;
            numUpdateRate.Value = 0;
        }

        private void updateRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Currency = Currency.Find(ListViewCurrencies.SelectedItems[0].Text);

            if (_Currency != null) cbCountryName.Text = _Currency.CountryName;

            UpdateLblCurrencyData(_Currency);

            tbCurrency.SelectedIndex = 1;
        }

        private void cbCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Currency = Currency.Find(cbCountryName.Text.Trim());
            numUpdateRate.Value = Convert.ToDecimal(_Currency.Rate);
            UpdateLblCurrencyData(_Currency);
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update the rate?", "Update Rate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Currency.UpdateRate(numUpdateRate.Value);
                UpdateItem(_Currency);
                ResetUpdateRate();
                MessageBox.Show($"Rate Updated Successfully {_Currency.CurrencyCode} ({_Currency.Rate}/$)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //
        ///////////Calculator///////////
        //
        private void ResetCalculator()
        {
            cbConvertFrom.ResetText();
            cbConvertTo.ResetText();
            lblConvertFromData.ResetText();
            lblConvertToData.ResetText();
            lblConversion.ResetText();
            numExchangeAmount.Value = 1;
            btnCalc.Enabled = false;
            btnReset.Visible = false;
        }

        private void cbConvertFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ConvertFrom = Currency.Find(cbConvertFrom.Text.Trim());

            UpdateLblConvertFrom(_ConvertFrom);
        }

        private void cbConvertTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ConvertTo = Currency.Find(cbConvertTo.Text.Trim());

            UpdateLblConvertTo(_ConvertTo);

            btnCalc.Enabled = true;
        }

        private void currencyCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ConvertFrom = Currency.Find(ListViewCurrencies.SelectedItems[0].Text);

            UpdateLblConvertFrom(_ConvertFrom);

            tbCurrency.SelectedIndex = 2;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal ConvertedAmount = _ConvertFrom.ConvertCurrency(numExchangeAmount.Value, _ConvertTo);

            lblConversion.Text = numExchangeAmount.Value.ToString() + ' ' + _ConvertFrom.CurrencyCode + " = " + Convert.ToSingle(ConvertedAmount).ToString() + ' ' + _ConvertTo.CurrencyCode;
                
            btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetCalculator();
        }

    }
}
