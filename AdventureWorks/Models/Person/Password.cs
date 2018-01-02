using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class Password
    {
        #region//Intializing Variables
        private int businessEntityId = 0;
        private string passwordHash = "N/A";
        private string passwordSalt = "N/A";
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

        public string PasswordHash
        {
            get
            {
                return this.passwordHash;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.passwordHash = null;
                }
                else
                {
                    this.passwordHash = value;
                }
            }
        }

        public string PasswordSalt
        {
            get
            {
                return this.passwordSalt;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.passwordSalt = null;
                }
                else
                {
                    this.passwordSalt = value;
                }
            }
        }
        #endregion
    }
}