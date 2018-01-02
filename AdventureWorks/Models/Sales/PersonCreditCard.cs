using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class PersonCreditCard
    {
        private int businessEntityId;

        public int BusinessEntityId
        {
            get { return businessEntityId; }
            set { businessEntityId = value; }
        }

        private int creditCardId;

        public int CreditCardId
        {
            get { return creditCardId; }
            set { creditCardId = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}