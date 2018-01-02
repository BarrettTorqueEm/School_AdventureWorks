using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class Location
    {
        #region//Initalizating Variables
        private int locationId = 0;
        private string name = "N/A";
        private double costRate = 0.0;
        private bool availability = false;
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int LocationId
        {
            get
            {
                return this.locationId;
            }
            set
            {
                if (value > 0)
                {
                    this.locationId = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.name = null;
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public double CostRate
        {
            get
            {
                return this.costRate;
            }
            set
            {
                if (value > 0)
                {
                    this.costRate = value;
                }
            }
        }

        public bool Availability
        {
            get
            {
                return this.availability;
            }
            set
            {
                this.availability = value;
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