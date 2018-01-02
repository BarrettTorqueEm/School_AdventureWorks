using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class ContactType
    {
        #region//Initializing Variables
        private int contactTypeId = 0;
        private string name = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int ContactTypeId
        {
            get
            {
                return this.contactTypeId;
            }
            set
            {
                if (value > 0)
                {
                    this.contactTypeId = value;
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