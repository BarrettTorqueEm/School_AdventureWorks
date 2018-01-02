using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class Address
    {
        #region //Inistalizing Variables
        private int addressId = 0;
        private string addressLine1 = "N/A";
        private string addressLine2 = "N/A";
        private string city = "N/A";
        private int stateProvinceId = 0;
        private string postalCode = "N/A";
        private string spatialLocation = "N/A";
        private string rowguid = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region //Gets and Sets
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

        public string AddressLine1
        {
            get
            {
                return this.addressLine1;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.addressLine1 = null;
                }
                else
                {
                    this.addressLine2 = value;
                }
            }
        }

        public string AddressLine2
        {
            get
            {
                return this.addressLine2;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.addressLine2 = null;
                }
                else
                {
                    this.addressLine2 = value;
                }
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.city = null;
                }
                else
                {
                    this.city = value;
                }
            }
        }

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

        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.postalCode = null;
                }
                else
                {
                    this.postalCode = value;
                }
            }
        }

        public string SpatialLocation
        {
            get
            {
                return this.spatialLocation;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.spatialLocation = null;
                }
                else
                {
                    this.spatialLocation = value;
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