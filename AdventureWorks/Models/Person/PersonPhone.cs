using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class PersonPhone
    {
        #region//Initalizing Variables
        private int businessEntityId = 0;
        private string phoneNumber = "N/A";
        private int phoneNumberTypeId = 0;
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

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.phoneNumber = null;
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }

        public int PhoneNumberTypeId
        {
            get
            {
                return this.phoneNumberTypeId;
            }
            set
            {
                if (value > 0)
                {
                    this.phoneNumberTypeId = value;
                }
            }
        }
        #endregion
    }
}