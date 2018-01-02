using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Person
{
    public class Person
    {
        #region//Inializing Vairables
        private int businessEntityId = 0;
        private string personType = "N/A";
        private string nameStyle = "N/A";
        private string title = "N/A";
        private string firstName = "N/A";
        private string middleName = "N/A";
        private string lastName = "N/A";
        private string suffix = "N/A";
        private string emailPromotion = "N/A";
        private string additionalContactInfo = "N/A";
        private string demorgraphics = "N/A";
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

        public string PersonType
        {
            get
            {
                return this.personType;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.personType = null;
                }
                else
                {
                    this.personType = value;
                }
            }
        }

        public string NameStyle
        {
            get
            {
                return this.nameStyle;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.nameStyle = null;
                }
                else
                {
                    this.nameStyle = value;
                }
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.title = null;
                }
                else
                {
                    this.title = value;
                }
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.firstName = null;
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.middleName = null;
                }
                else
                {
                    this.middleName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.lastName = null;
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string Suffix
        {
            get
            {
                return this.suffix;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.suffix = null;
                }
                else
                {
                    this.suffix = value;
                }
            }
        }

        public string EmailPromotion
        {
            get
            {
                return this.emailPromotion;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.emailPromotion = null;
                }
                else
                {
                    this.emailPromotion = value;
                }
            }
        }

        public string AdditionalContactInfo
        {
            get
            {
                return this.additionalContactInfo;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.additionalContactInfo = null;
                }
                else
                {
                    this.additionalContactInfo = value;
                }
            }
        }

        public string Demographics
        {
            get
            {
                return this.demorgraphics;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.demorgraphics = null;
                }
                else
                {
                    this.demorgraphics = value;
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