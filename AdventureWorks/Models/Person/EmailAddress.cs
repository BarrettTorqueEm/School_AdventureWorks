using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class EmailAddress
    {
        #region//Initializing Variables
        private int businessEntityId = 0;
        private int emailAddressId = 0;
        private string emailAddress = "N/A";
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

        public int EmailAdressId
        {
            get
            {
                return this.emailAddressId;
            }
            set
            {
                if (value > 0)
                {
                    this.emailAddressId = value;
                }
            }
        }

        public string AEmailAddress
        {
            get
            {
                return this.emailAddress;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.emailAddress = null;
                }
                else
                {
                    this.emailAddress = value;
                }
            }
        }
        #endregion
    }
}