using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class CountyRegion
    {
        #region //Inistializing Variables
        private int countryRegionCode = 0;
        private string name = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region //Gets and Sets
        public int CountryRegionCode
        {
            get
            {
                return this.countryRegionCode;
            }
            set
            {
                if (value > 0)
                {
                    this.countryRegionCode = value;
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