using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.dbo
{
    public class AWBuildVersion
    {
        #region// Iniatiating Variables
        private int systemInformationId = 0;
        private int databaseVersion = 0;
        private string versionDate = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region// Gets and Sets
        public int SystemInformationId
        {
            get
            {
                return this.systemInformationId;
            }
            set
            {
                if (value > 0)
                {
                    this.systemInformationId = value;
                }
            }
        }

        public int DatabaseVersion
        {
            get
            {
                return this.databaseVersion;
            }
            set
            {
                if (value > 0)
                {
                    this.databaseVersion = value;
                }
            }
        }

        public string VersionDate
        {
            get
            {
                return this.versionDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.versionDate = null;
                }
                else
                {
                    this.versionDate = value;
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

        #region //Constuctors
        public AWBuildVersion() : this(0, 0, "N/A", "N/A")
        {

        }
        public AWBuildVersion(int aSystemInformationId) : this(aSystemInformationId, 0, "N/A", "N/A")
        {

        }
        public AWBuildVersion(int aSystemInformationId, int aDatabaseVersion) : this(aSystemInformationId, aDatabaseVersion, "N/A", "N/A")
        {

        }
        public AWBuildVersion(int aSystemInformationId, int aDatabaseVersion, string aVersionDate) : this(aSystemInformationId, aDatabaseVersion, aVersionDate, "N/A")
        {

        }
        public AWBuildVersion(int aSystemInformationId, int aDatabaseVersion, string aVersionDate, string aModifiedDate)
        {
            this.SystemInformationId = aSystemInformationId;
            this.DatabaseVersion = aDatabaseVersion;
            this.VersionDate = aVersionDate;
            this.ModifiedDate = aModifiedDate;
        }

        #endregion

        #region// Display Methods
        public override string ToString()
        {
            string aMessage = "";

            aMessage = aMessage + "System Information Id: " + SystemInformationId + "\n";
            aMessage = aMessage + "Database Version: " + DatabaseVersion + "\n";
            aMessage = aMessage + "Version Date: " + VersionDate + "\n";
            aMessage = aMessage + "Modified Date: " + ModifiedDate + "\n";

            return aMessage;
        }

        public string Display()
        {
            string aMessage = "";

            aMessage = aMessage + "System Information Id: " + SystemInformationId + "<br />";
            aMessage = aMessage + "Database Version: " + DatabaseVersion + "<br />";
            aMessage = aMessage + "Version Date: " + VersionDate + "<br />";
            aMessage = aMessage + "Modified Date: " + ModifiedDate + "<br />";

            return aMessage;
        }

        #endregion
    }
}