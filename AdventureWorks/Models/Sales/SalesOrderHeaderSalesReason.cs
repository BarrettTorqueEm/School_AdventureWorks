using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SalesOrderHeaderSalesReason
    {
        private int businessEntityId;

        public int BusinessEntityId
        {
            get { return businessEntityId; }
            set { businessEntityId = value; }
        }

        private int salesOrderId;

        public int SalesOrderId
        {
            get { return salesOrderId; }
            set { salesOrderId = value; }
        }

        private int salesReasonId;

        public int SalesReasonId
        {
            get { return salesReasonId; }
            set { salesReasonId = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}