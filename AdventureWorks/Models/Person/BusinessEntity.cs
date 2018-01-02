using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class BusinessEntity
    {
        #region//Initializing Variables
        private int businessEntityId = 0;
        private string rowguid = "N/A";
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