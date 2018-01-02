using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.HumanResources
{
    public class Employee
    {
        #region // Inistalizing Variables
        private int businessEntityId = 0;
        private int nationalIdNumber = 0;
        private int loginId = 0;
        private int shiftId = 0;
        private string jobTitle = "N/A";
        private string birthDate = "N/A";
        private bool maritalStatus = false; //False = Not married, True = Married
        private bool gender = false; // False = Male, True = Female
        private string hireDate = "N/A";
        private string salariedFlag = "N/A";
        private int vacationHours = 0;
        private int sickLeaveHours = 0;
        private string currentFlag = "N/A";
        private string rowguild = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region //Gets and Sets
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

        public int NationalIdNumber
        {
            get
            {
                return this.nationalIdNumber;
            }
            set
            {
                if (value > 0)
                {
                    this.nationalIdNumber = value;
                }
            }
        }

        public int LoginId
        {
            get
            {
                return this.loginId;
            }
            set
            {
                if (value > 0)
                {
                    this.loginId = value;
                }
            }
        }

        public int ShiftId
        {
            get
            {
                return this.shiftId;
            }
            set
            {
                if (value > 0)
                {
                    this.shiftId = value;
                }
            }
        }

        public string JobTitle
        {
            get
            {
                return this.jobTitle;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.jobTitle = null;
                }
                else
                {
                    this.jobTitle = value;
                }
            }
        }

        public string BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.birthDate = null;
                }
                else
                {
                    this.birthDate = value;
                }
            }
        }

        public bool MaritalStatus
        {
            get
            {
                return this.maritalStatus;
            }
            set
            {
                this.maritalStatus = value;
            }
        }

        public bool Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public string HireDate
        {
            get
            {
                return this.hireDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.hireDate = null;
                }
                else
                {
                    this.hireDate = value;
                }
            }
        }

        public string SalariedFlag
        {
            get
            {
                return this.salariedFlag;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.salariedFlag = null;
                }
                else
                {
                    this.salariedFlag = value;
                }
            }
        }

        public int VacationHours
        {
            get
            {
                return this.vacationHours;
            }
            set
            {
                if (value > 0)
                {
                    this.vacationHours = value;
                }
            }
        }

        public int SickLeaveHours
        {
            get
            {
                return this.sickLeaveHours;
            }
            set
            {
                if (value > 0)
                {
                    this.sickLeaveHours = value;
                }
            }
        }

        public string CurrentFlag
        {
            get
            {
                return this.currentFlag;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.currentFlag = null;
                }
                else
                {
                    this.currentFlag = value;
                }
            }
        }

        public string Rowguild
        {
            get
            {
                return this.rowguild;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.rowguild = null;
                }
                else
                {
                    this.rowguild = value;
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