using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.HumanResources
{
    public class EmployeeDepartmentHistory
    {
        #region //Inizalizing Variables
        private int businessEntityId = 0;
        private int departmentId = 0;
        private string startDate = "N/A";
        private int shiftId = 0;
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

        public int DepartmentId
        {
            get
            {
                return this.departmentId;
            }
            set
            {
                if (value > 0)
                {
                    this.departmentId = value;
                }
            }
        }

        public string StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.startDate = null;
                }
                else
                {
                    this.startDate = value;
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
        #endregion
    }
}