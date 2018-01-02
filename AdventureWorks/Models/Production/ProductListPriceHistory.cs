using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductListPriceHistory
    {
        #region//Initiziating Variables
        private int productId = 0;
        private string startDate = "N/A";
        private string endDate = "N/A";
        private double listPrice = 0.0;
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets 
        public int ProductId
        {
            get
            {
                return this.productId;
            }
            set
            {
                if (value > 0)
                {
                    this.productId = value;
                }
            }
        }

        public string StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.startDate = null;
                }
                else
                {
                    this.startDate = value;
                }
            }
        }

        public string EndDate
        {
            get
            {
                return this.endDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.endDate = null;
                }
                else
                {
                    this.endDate = value;
                }
            }
        }

        public double ListPrice
        {
            get
            {
                return this.listPrice;
            }
            set
            {
                if (value > 0)
                {
                    this.listPrice = value;
                }
            }
        }

        public string ModifiedDate
        {
            get
            {
                return this.modifiedDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.modifiedDate = null;
                }
                else
                {
                    this.modifiedDate = value;
                }
            }
        }
        #endregion
    }
}