using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductInventory
    {
        #region//Iniatializing Variables
        private int productId = 0;
        private int locationId = 0;
        private string shelf = "N/A";
        private string bin = "N/A";
        private int quantity = 0;
        private string rowguid = "N/A";
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

        public string Shelf
        {
            get
            {
                return this.shelf;
            }
            set
            {
                if(value.Length < 1)
                {
                    this.shelf = null;
                }
                else
                {
                    this.shelf = value;
                }
            }
        }

        public string Bin
        {
            get
            {
                return this.bin;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.bin = null;
                }
                else
                {
                    this.bin = value;
                }
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value > 0)
                {
                    this.quantity = value;
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
                if(value.Length < 1)
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