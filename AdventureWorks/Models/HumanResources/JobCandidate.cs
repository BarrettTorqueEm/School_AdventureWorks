using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.HumanResources
{
    public class JobCandidate
    {
        #region //Inisializing Variables
        private int businessEntityId = 0;
        private int jobCandidateId = 0;
        private string resume = "N/A";
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

        public int JobCandidateId
        {
            get
            {
                return this.jobCandidateId;
            }
            set
            {
                if (value > 0)
                {
                    this.jobCandidateId = value;
                }
            }
        }

        public string Resume
        {
            get
            {
                return this.resume;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.resume = null;
                }
                else
                {
                    this.resume = value;
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