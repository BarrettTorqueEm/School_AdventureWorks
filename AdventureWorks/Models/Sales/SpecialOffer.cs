using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SpecialOffer
    {
        private int specialOfferId;

        public int SpecialOfferId
        {
            get { return specialOfferId; }
            set { specialOfferId = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string discountPct;
        
        public string DiscountPct
        {
            get { return discountPct; }
            set { discountPct = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string startDate;

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private string endDate;

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private int minQty;

        public int MinQty
        {
            get { return minQty; }
            set { minQty = value; }
        }

        private int maxQty;

        public int MaxQty
        {
            get { return maxQty; }
            set { maxQty = value; }
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