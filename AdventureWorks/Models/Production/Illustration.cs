using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class Illustration
    {
        #region//Initalizing Variables
        private int illustrationId = 0;
        private string diagram = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets 
        public int IllustrationId
        {
            get
            {
                return this.illustrationId;
            }
            set
            {
                if (value > 0)
                {
                    this.illustrationId = value;
                }
            }
        }

        public string Diagram
        {
            get
            {
                return this.diagram;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.diagram = null;
                }
                else
                {
                    this.diagram = value;
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