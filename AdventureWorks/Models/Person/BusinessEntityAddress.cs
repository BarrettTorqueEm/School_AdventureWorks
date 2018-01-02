using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class BusinessEntityAddress
    {
        #region//Initzialing Variables
        private int addressId = 0;
        private int businessEntityId = 0;
        private int addressTypeId = 0;
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int AddressId
        {
            get
            {
                return this.addressId;
            }
            set
            {
                if (value > 0)
                {
                    this.addressId = value;
                }
            }
        }

        public int BusinessEntityId
        {
            get
            {
                return this.businessEntityId;
            }
            set
            {
                if(value > 0)
                {
                    this.businessEntityId = value;
                }
            }
        }

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