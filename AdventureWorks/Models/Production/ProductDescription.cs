using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductDescription
    {
        #region//Initalizing Variables
        private int productDescriptionId = 0;
        private string description = "N/A";
        private string rowguid = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets 
        public int ProductDescriptionId
        {
            get
            {
                return this.productDescriptionId;
            }
            set
            {
                if (value > 0)
                {
                    this.productDescriptionId = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.description = null;
                }
                else
                {
                    this.description = value;
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