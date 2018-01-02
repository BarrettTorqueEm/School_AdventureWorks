using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SalesPersonQuotaHistory
    {
        private int businessEntityId;

        public int BusinessEntityId
        {
            get { return businessEntityId; }
            set { businessEntityId = value; }
        }

        private string quotaDate;

        public string QuotaDate
        {
            get { return quotaDate; }
            set { quotaDate = value; }
        }

        private int salesQuota;

        public int SalesQuota
        {
            get { return salesQuota; }
            set { salesQuota = value; }
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