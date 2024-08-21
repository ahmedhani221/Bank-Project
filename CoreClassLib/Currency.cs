using System;
using System.Collections.Generic;
using System.IO;

namespace CoreClassLib
{
    public class Currency
    {
        public Currency(string countryName, string currencyCode, string currencyName, decimal rate)
        {
            CountryName = countryName;
            CurrencyCode = currencyCode;
            CurrencyName = currencyName;
            Rate = rate;
        }

        public string CountryName { get; }

        public string CurrencyCode { get; }

        public string CurrencyName { get; }

        public decimal Rate { get; set; }

        private bool isMarkedDeleted = false;

        static private Currency _ConvertLineToCurrency(string Line, string Separator = "#//#")
        {
            string[] currency = Line.Split(new string[] { Separator }, StringSplitOptions.None);

            return new Currency(currency[0], currency[1], currency[2], Convert.ToDecimal(currency[3]));
        }

        static private string _ConvertCurrencyToLine(Currency currency, string Separator = "#//#")
        {
            string Line = "";

            Line += currency.CountryName + Separator;
            Line += currency.CurrencyCode + Separator;
            Line += currency.CurrencyName + Separator;
            Line += currency.Rate;

            return Line;
        }

        static public List<Currency> GetCurrenciesData()
        {
            List<Currency> currencies = new List<Currency>();

            foreach(string line in File.ReadLines("Currencies.txt"))
            {
                currencies.Add(_ConvertLineToCurrency(line));
            }

            return currencies;
        }

        static private void _SaveCurrenciesData(List<Currency> currencies)
        {
            List<string> lines = new List<string>();

            foreach(Currency cur in currencies)
            {
                if (cur.isMarkedDeleted == false) lines.Add(_ConvertCurrencyToLine(cur));
            }

            File.WriteAllLines("Currencies.txt", lines);
        }

        public void UpdateRate(decimal newRate)
        {
            List<Currency> currencies = GetCurrenciesData();
            bool isUpdated = false;

            for (int i = 0; i < currencies.Count; i++)
            {
                if (currencies[i].CountryName == this.CountryName)
                {
                    currencies[i].Rate = newRate;
                    this.Rate = newRate;
                    isUpdated = true;
                    break;
                }
            }

            if (isUpdated)
            {
                _SaveCurrenciesData(currencies);
            }
            
        }

        static public Currency Find(string findByNameOrCode)
        {
            List<Currency> currencies = GetCurrenciesData();

            foreach (Currency currency in currencies)
            {
                if (currency.CountryName == findByNameOrCode || currency.CurrencyCode == findByNameOrCode)
                {
                    return currency;
                }
            }

            return null;
        }

        decimal ConvertToDollar(decimal amount)
        {
            decimal usdAmount = amount / Rate;

            return usdAmount;
        }

        public decimal ConvertCurrency(decimal amount, Currency currency2)
        {
            decimal usdAmount = ConvertToDollar(amount);

            if (currency2.CurrencyCode == "USD") return usdAmount;


            return usdAmount * currency2.Rate;
        }
    }
}
