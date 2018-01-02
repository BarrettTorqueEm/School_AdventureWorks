using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class AddressType
    {
        #region//Initailizing Variables
        private int addressTypeId = 0;
        private string name = "N/A";
        private string rowguid = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int AddressTypeId
        {
            get
            {
                return this.addressTypeId;
            }
            set
            {
                if (value > 0)
                {
                    this.addressTypeId = value;
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