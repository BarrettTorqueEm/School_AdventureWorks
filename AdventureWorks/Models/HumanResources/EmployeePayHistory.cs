using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.HumanResources
{
    public class EmployeePayHistory
    {
        #region //Inisalizing Variables
        private int businessEntityId = 0;
        private string rateChangeDate = "N/A";
        private double rate = 0.0;
        private int payFrequency = 0;
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int BusinessEntityId
        {
            get
            {
                return this.businessEntityId;
            }
            set
            {
                if (value > 0)
                {
                    this.businessEntityId = value;
                }
            }
        }

        public string RateChangeDate
        {
            get
            {
                return this.rateChangeDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.rateChangeDate = null;
                }
                else
                {
                    this.rateChangeDate = value;
                }
            }
        }

        public double Rate
        {
            get
            {
                return this.rate;
            }
            set
            {
                if (value > 0.0)
                {
                    this.rate = value;
                }
            }
        }

        public int PayFrequencey
        {
            get
            {
                return this.payFrequency;
            }
            set
            {
                if (value > 0)
                {
                    this.payFrequency = value;
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