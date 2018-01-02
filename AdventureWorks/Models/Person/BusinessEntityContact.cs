using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class BusinessEntityContact
    {
        #region//Inizializing Variables
        private int bussinessEntityId = 0;
        private int personId = 0;
        private int contactTypeId = 0;
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int BussinessEntityId
        {
            get
            {
                return this.bussinessEntityId;
            }
            set
            {
                if (value > 0)
                {
                    this.bussinessEntityId = value;
                }
            }
        }

        public int PersonId
        {
            get
            {
                return this.personId;
            }
            set
            {
                if (value > 0)
                {
                    this.personId = value;
                }
            }
        }

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