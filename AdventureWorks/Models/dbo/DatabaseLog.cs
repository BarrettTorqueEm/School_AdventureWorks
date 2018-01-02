using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.dbo
{
    public class DatabaseLog
    {
        #region// Iniatiating variables
        private int databaseLogId = 0;
        private string postTime = "N/A";
        private string databaseUser = "N/A";
        private string aEvent = "N/A";
        private string schema = "N/A";
        private string aObject = "N/A";
        private string tsql = "N/A";
        private string xmlEvent = "N/A";
        #endregion

        #region// Gets and sets
        public int DatabaseLogId
        {
            get
            {
                return this.databaseLogId;
            }
            set
            {
                if(value > 0)
                {
                    this.databaseLogId = value;
                }
            }
        }

        public string PostTime
        {
            get
            {
                return this.postTime;
            }
            set
            {
                if(value.Length < 1)
                {
                    this.postTime = null;
                }
                else
                {
                    this.postTime = value;
                }
            }
        }

        public string DatabaseUser
        {
            get
            {
                return this.databaseUser;
            }
            set
            {
                if(value.Length < 1)
                {
                    this.databaseUser = null;
                }
                else
                {
                    this.databaseUser = value;
                }
            }
        }

        public string AEvent
        {
            get
            {
                return this.aEvent;
            }
            set
            {
                if(value.Length < 1)
                {
                    this.aEvent = null;
                }
                else
                {
                    this.aEvent = value;
                }
      
            }
        }

        public string Schema
        {
            get
            {
                return this.schema;
            }
            set
            {
                if(value.Length < 1)
                {
                    this.schema = null;
                }
                else
                {
                    this.schema = value;
                }
            }
        }

        public string AObject
        {
            get
            {
                return this.aObject;
            }
            set
            {
                if(value.Length < 1)
                {
                    this.aObject = null;
                }
                else
                {
                    this.aObject = value;
                }
            }
        }

        public string Tsql
        {
            get
            {
                return this.tsql;
            }
            set
            {
                if(value.Length < 1)
                {
                    this.tsql = null;
                }
                else
                {
                    this.tsql = value;
                }
            }
        }

        public string XmlEvent
        {
            get
            {
                return this.xmlEvent;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.xmlEvent = null;
                }
                else
                {
                    this.xmlEvent = value;
                }
            }
        }
        #endregion

        #region //Constructor
        public DatabaseLog() : this(0, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public DatabaseLog(int aDatabaseLogId) : this(aDatabaseLogId, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public DatabaseLog(int aDatabaseLogId, string aPostTime) : this(aDatabaseLogId, aPostTime, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public DatabaseLog(int aDatabaseLogId, string aPostTime, string aDatabaseUser) : this(aDatabaseLogId, aPostTime, aDatabaseUser, "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public DatabaseLog(int aDatabaseLogId, string aPostTime, string aDatabaseUser, string aEvent) : this(aDatabaseLogId, aPostTime, aDatabaseUser, aEvent, "N/A", "N/A", "N/A", "N/A")
        {

        }
        public DatabaseLog(int aDatabaseLogId, string aPostTime, string aDatabaseUser, string aEvent, string aSchema) : this(aDatabaseLogId, aPostTime, aDatabaseUser, aEvent, aSchema, "N/A", "N/A", "N/A")
        {

        }
        public DatabaseLog(int aDatabaseLogId, string aPostTime, string aDatabaseUser, string aEvent, string aSchema, string aObject) : this(aDatabaseLogId, aPostTime, aDatabaseUser, aEvent, aSchema, aObject,"N/A", "N/A")
        {

        }
        public DatabaseLog(int aDatabaseLogId, string aPostTime, string aDatabaseUser, string aEvent, string aSchema, string aObject, string aTsql) : this(aDatabaseLogId, aPostTime, aDatabaseUser, aEvent, aSchema, aObject, aTsql, "N/A")
        {

        }
        public DatabaseLog(int aDatabaseLogId, string aPostTime, string aDatabaseUser, string aEvent, string aSchema, string aObject, string aTsql, string aXmlEvent)
        {
            this.DatabaseLogId = aDatabaseLogId;
            this.PostTime = aPostTime;
            this.AEvent = aEvent;
            this.Schema = aSchema;
            this.AObject = aObject;
            this.Tsql = aTsql;
            this.XmlEvent = aXmlEvent;
        }
        #endregion

        #region// Display Methods
        public override string ToString()
        {
            string aMessage = "";

            aMessage = aMessage + "Database Log ID: " + DatabaseLogId + "\n";
            aMessage = aMessage + "Post Time: " + PostTime + "\n";
            aMessage = aMessage + "Database User: " + DatabaseUser + "\n";
            aMessage = aMessage + "Event: " + AEvent + "\n";
            aMessage = aMessage + "Schema: " + Schema + "\n";
            aMessage = aMessage + "Object: " + AObject + "\n";
            aMessage = aMessage + "SQL: " + Tsql + "\n";
            aMessage = aMessage + "XML Event: " + XmlEvent + "\n";

            return aMessage;
        }

        public string Display()
        {
            string aMessage = "";

            aMessage = aMessage + "Database Log ID: " + DatabaseLogId + "\n";
            aMessage = aMessage + "Post Time: " + PostTime + "\n";
            aMessage = aMessage + "Database User: " + DatabaseUser + "\n";
            aMessage = aMessage + "Event: " + AEvent + "\n";
            aMessage = aMessage + "Schema: " + Schema + "\n";
            aMessage = aMessage + "Object: " + AObject + "\n";
            aMessage = aMessage + "SQL: " + Tsql + "\n";
            aMessage = aMessage + "XML Event: " + XmlEvent + "\n";

            return aMessage;
        }
        #endregion
    }
}