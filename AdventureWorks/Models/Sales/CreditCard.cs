using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class CreditCard
    {
        private int creditCardId;

        public int CreditCardId
        {
            get { return creditCardId; }
            set { creditCardId = value; }
        }

        private string cardType;

        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }

        private string cardNumber;

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        private string expMonth;

        public string ExpMonth
        {
            get { return expMonth; }
            set { expMonth = value; }
        }

        private string expYear;

        public string ExpYear
        {
            get { return expYear; }
            set { expYear = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}