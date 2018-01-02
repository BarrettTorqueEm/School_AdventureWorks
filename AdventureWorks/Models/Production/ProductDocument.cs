using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductDocument
    {
        #region//Initatlizing Variabels
        private int productId = 0;
        private string documentNode = "N/A";
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
                if(value > 0)
                {
                    this.productId = value;
                }
            }
        }

        public string DocumentNode
        {
            get
            {
                return this.documentNode;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.documentNode = null;
                }
                else
                {
                    this.documentNode = value;
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