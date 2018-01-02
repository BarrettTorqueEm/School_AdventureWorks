using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class BillOfMaterials
    {
        #region//Iniatializing Variables
        private int billOfMaterialsId = 0;
        private int productAssemblyId = 0;
        private int componentId = 0;
        private string startDate = "N/A";
        private string endDate = "N/A";
        private string unitMeasureCode = "N/A";
        private int bomLevel = 0;
        private int perAssemblyQty = 0;
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int BillOfMaterialsId
        {
            get
            {
                return this.billOfMaterialsId;
            }
            set
            {
                if (value > 0)
                {
                    this.billOfMaterialsId = value;
                }
            }
        }

        public int ProductAssemblyId
        {
            get
            {
                return this.productAssemblyId;
            }
            set
            {
                if (value > 0)
                {
                    this.productAssemblyId = value;
                }
            }
        }

        public int ComponentId
        {
            get
            {
                return this.componentId;
            }
            set
            {
                if(value > 0)
                {
                    this.componentId = value;
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

        public string UnitMeasureCode
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

        public int BomLevel
        {
            get
            {
                return this.bomLevel;
            }
            set
            {
                if (value > 0)
                {
                    this.bomLevel = value;
                }
            }
        }

        public int PerAssemblyQty
        {
            get
            {
                return this.perAssemblyQty;
            }
            set
            {
                if (value > 0)
                {
                    this.perAssemblyQty = value;
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