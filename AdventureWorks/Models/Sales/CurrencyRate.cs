using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class CurrencyRate
    {
        private int currencyRateId;

        public int CurrencyRateId
        {
            get { return currencyRateId; }
            set { currencyRateId = value; }
        }

        private string currencyRateDate;

        public string CurrencyRateDate
        {
            get { return currencyRateDate; }
            set { currencyRateDate = value; }
        }

        private int fromCurrencyCode;

        public int FromCurrencyCode
        {
            get { return fromCurrencyCode; }
            set { fromCurrencyCode = value; }
        }

        private int toCurrencyCode;

        public int ToCurrencyCode
        {
            get { return toCurrencyCode; }
            set { toCurrencyCode = value; }
        }

        private double averageRate;

        public double AverageRate
        {
            get { return averageRate; }
            set { averageRate = value; }
        }

        private double endOfDateRate;

        public double EndOfDateRate
        {
            get { return endOfDateRate; }
            set { endOfDateRate = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}