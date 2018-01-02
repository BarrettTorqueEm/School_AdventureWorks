using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Purchasing
{
    public class ProductVendor
    {
        private int businessEntityId;

        public int BusinessEntityId
        {
            get { return businessEntityId; }
            set { businessEntityId = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private string averageLeadTime;

        public string AverageLeadTime
        {
            get { return averageLeadTime; }
            set { averageLeadTime = value; }
        }

        private double standardPrice;

        public double StandardPrice
        {
            get { return standardPrice; }
            set { standardPrice = value; }
        }

        private double lastReciptCost;

        public double LastReciptCost
        {
            get { return lastReciptCost; }
            set { lastReciptCost = value; }
        }

        private string lastReceiptDate;

        public string LastReciptDate
        {
            get { return lastReceiptDate; }
            set { lastReceiptDate = value; }
        }

        private int minOrderQty;

        public int MinOrderQty
        {
            get { return minOrderQty; }
            set { minOrderQty = value; }
        }

        private int maxOrderQty;

        public int MaxORderQty
        {
            get { return maxOrderQty; }
            set { maxOrderQty = value; }
        }

        private int onOrderQty;

        public int OnOrderQty
        {
            get { return onOrderQty; }
            set { onOrderQty = value; }
        }

        private int unitMeasureCode;

        public int UnitMeasureCode
        {
            get { return unitMeasureCode; }
            set { unitMeasureCode = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}