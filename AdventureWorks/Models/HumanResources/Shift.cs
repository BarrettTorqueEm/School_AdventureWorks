using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.HumanResources
{
    public class Shift
    {
        #region //Inisializing Variables
        private int shiftId = 0;
        private string name = "N/A";
        private string startTime = "N/A";
        private string endTime = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region //Gets and Sets
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

        public string StartTime
        {
            get
            {
                return this.startTime;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.startTime = null;
                }
                else
                {
                    this.startTime = value;
                }
            }
        }

        public string EndTime
        {
            get
            {
                return this.endTime;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.endTime = null;
                }
                else
                {
                    this.endTime = value;
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
    }
    #endregion
}