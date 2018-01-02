using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class Customer
    {
        private int customerId;

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        private int personId;

        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }

        private int storeId;

        public int StoreId
        {
            get { return storeId; }
            set { storeId = value; }
        }

        private int territoryId;

        public int TerritoryId
        {
            get { return territoryId; }
            set { territoryId = value; }
        }

        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private string rowguid;

        public string Rowguid
        {
            get { return rowguid; }
            set { rowguid = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}