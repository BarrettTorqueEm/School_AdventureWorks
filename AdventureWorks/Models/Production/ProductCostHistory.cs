using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductCostHistory
    {
        #region//Initaizling Variables
        private int productId = 0;
        private string startDate = "N/A";
        private string endDate = "N/A";
        private double standardCost = 0.0;
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

        public double StandardCost
        {
            get
            {
                return this.standardCost;
            }
            set
            {
                if (value > 0)
                {
                    this.standardCost = value;
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