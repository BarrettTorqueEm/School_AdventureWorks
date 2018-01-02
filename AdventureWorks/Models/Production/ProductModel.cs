using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductModel
    {
        #region//Initializing Variables
        private int productModelId = 0;
        private string name = "N/A";
        private string catalogDescription = "N/A";
        private string instructions = "N/A";
        private string rowguid = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int ProductModelId
        {
            get
            {
                return this.productModelId;
            }
            set
            {
                if (value > 0)
                {
                    this.productModelId = value;
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

        public string CatalogDescritption
        {
            get
            {
                return this.catalogDescription;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.catalogDescription = null;
                }
                else
                {
                    this.catalogDescription = value;
                }
            }
        }

        public string Instructions
        {
            get
            {
                return this.instructions;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.instructions = null;
                }
                else
                {
                    this.instructions = value;
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
                    this.rowguid = null;
                }
                else
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