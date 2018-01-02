using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class StateProvice
    {
        #region //Inisalizing Variables
        private int stateProvinceId = 0;
        private int stateProvinceCode = 0;
        private int countyRegionCode = 0;
        private string isOnlyStateProviceFlag = "N/A";
        private string name = "N/A";
        private int territoryId = 0;
        private string rowguid = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int StateProvinceId
        {
            get
            {
                return this.stateProvinceId;
            }
            set
            {
                if (value > 0)
                {
                    this.stateProvinceId = value;
                }
            }
        }

        public int StateProvinceCode
        {
            get
            {
                return this.stateProvinceCode;
            }
            set
            {
                if (value > 0)
                {
                    this.stateProvinceCode = value;
                }
            }
        }

        public int CountryRegionCode
        {
            get
            {
                return this.countyRegionCode;
            }
            set
            {
                if (value > 0)
                {
                    this.countyRegionCode = value;
                }
            }
        }

        public string IsOnlyStateProvinceFlag
        {
            get
            {
                return this.isOnlyStateProviceFlag;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.isOnlyStateProviceFlag = null;
                }
                else
                {
                    this.isOnlyStateProviceFlag = value;
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

        public int TerritoryId
        {
            get
            {
                return this.territoryId;
            }
            set
            {
                if (value > 0)
                {
                    this.territoryId = value;
                }
            }
        }

        public string Rowguid
        {
            get
            {
                return this.rowguid;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.rowguid = value;
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