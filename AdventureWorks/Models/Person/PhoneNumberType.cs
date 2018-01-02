using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class PhoneNumberType
    {
        #region//Inializing Variables
        private int phoneNumberTypeId = 0;
        private string name = "N/A";
        #endregion

        #region//Gets and Sets
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
#endregion
    }
}