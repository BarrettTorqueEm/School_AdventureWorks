using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Purchasing
{
    public class Vendor
    {
        private int businessEntityId;

        public int BusinessEntityId
        {
            get { return businessEntityId; }
            set { businessEntityId = value; }
        }

        private int accountNumber;

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int creditRating;

        public int CreditRating
        {
            get { return creditRating; }
            set { creditRating = value; }
        }

        private string preferredVendorStatus;

        public string PreferredVendorStatus
        {
            get { return preferredVendorStatus; }
            set { preferredVendorStatus = value; }
        }

        private string activeFlag;

        public string ActiveFlag
        {
            get { return activeFlag; }
            set { activeFlag = value; }
        }

        private string purchasingWebServiceUrl;

        public string PurchasingWebServiceUrl
        {
            get { return purchasingWebServiceUrl; }
            set { purchasingWebServiceUrl = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}