using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.HumanResources
{
    public class Department
    {
        #region// Inisalizing Variables
        private int departmentId = 0;
        private string name = "N/A";
        private string groupName = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region// Gets and Sets
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

        public string GroupName
        {
            get
            {
                return this.groupName;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.groupName = null;
                }
                else
                {
                    this.groupName = value;
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

        #region//Constructors

        public Department() : this(0, "N/A", "N/A", "N/A") { }

        public Department(int aDepartmentId) : this(aDepartmentId, "N/A", "N/A", "N/A") { }

        public Department(int aDepartmentId, string aName) : this(aDepartmentId, aName, "N/A", "N/A") { }

        public Department(int aDepartmentId, string aName, string aGroupName) : this(aDepartmentId, aName, aGroupName, "N/A") { }

        public Department(int aDepartmentId, string aName, string aGroupName, string aModifiedDate)
        {
            this.DepartmentId = aDepartmentId;
            this.Name = aName;
            this.GroupName = aGroupName;
            this.ModifiedDate = aModifiedDate;
        }

        #endregion

        #region//Display
        public override string ToString()
        {
            string aMessage = "Department ID: " + DepartmentId + "\n";
            aMessage = aMessage + "Name: " + Name + "\n";
            aMessage = aMessage + "Group Name: " + GroupName + "\n";
            aMessage = aMessage + "Modified Date: " + ModifiedDate + "\n";
            return aMessage;
        }

        public string Display()
        {
            string aMessage = "Department ID: " + DepartmentId + "\n";
            aMessage = aMessage + "Name: " + Name + "<br />";
            aMessage = aMessage + "Group Name: " + GroupName + "<br />";
            aMessage = aMessage + "Modified Date: " + ModifiedDate + "<br />";
            return aMessage;
        }
        #endregion
    }
}