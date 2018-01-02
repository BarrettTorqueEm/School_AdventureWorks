using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.dbo
{
    public class ErrorLog
    {
        #region// Inisiating variables
        private int errorLogId = 0;
        private string errorTime = "N/A";
        private string userName = "N/A";
        private int errorNumber = 0;
        private int errorSeverity = 0;
        private string errorState = "N/A";
        private string errorProcedure = "N/A";
        private int errorLine = 0;
        private string errorMessage = "N/A";
        #endregion

        #region// Gets and Sets
        public int ErrorLogId
        {
            get
            {
                return this.errorLogId;
            }
            set
            {
                if (value > 0)
                {
                    this.errorLogId = 0;
                }
            }
        }

        public string ErrorTime
        {
            get
            {
                return this.errorTime;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.errorTime = null;
                }
                else
                {
                    this.errorTime = value;
                }
            }
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.userName = null;
                }
                else
                {
                    this.userName = value;
                }
            }
        }

        public int ErrorNumber
        {
            get
            {
                return this.errorNumber;
            }
            set
            {
                if (value > 0)
                {
                    this.errorNumber = value;
                }
            }
        }

        public int ErrorSeverity
        {
            get
            {
                return this.errorSeverity;
            }
            set
            {
                if (value > 0)
                {
                    this.errorSeverity = value;
                }
            }
        }

        public string ErrorState
        {
            get
            {
                return this.errorState;
            }
            set
            {
                this.errorState = value;
            }

        }

        public string ErrorProcedure
        {
            get
            {
                return this.errorProcedure;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.errorProcedure = null;
                }
                else
                {
                    this.errorProcedure = value;
                }
            }
        }

        public int ErrorLine
        {
            get
            {
                return this.errorLine;
            }
            set
            {
                if (value > 0)
                {
                    this.errorLine = value;
                }
            }
        }

        public string ErrorMessage
        {
            get
            {
                return this.ErrorMessage;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.errorMessage = null;
                }
                else
                {
                    this.errorMessage = value;
                }
            }
        }
        #endregion

        #region//Construtors
        public ErrorLog() : this(0, "N/A", "N/A", 0, 0, "N/A", "N/A", 0, "N/A") { }

        public ErrorLog(int aErrorLogID) : this(aErrorLogID, "N/A", "N/A", 0, 0, "N/A", "N/A", 0, "N/A") { }

        public ErrorLog(int aErrorLogID, string aErrorTime) : this(aErrorLogID, aErrorTime, "N/A", 0, 0, "N/A", "N/A", 0, "N/A") { }

        public ErrorLog(int aErrorLogID, string aErrorTime, string aUserName) : this(aErrorLogID, aErrorTime, aUserName, 0, 0, "N/A", "N/A", 0, "N/A") { }

        public ErrorLog(int aErrorLogID, string aErrorTime, string aUserName, int aErrorNumber) : this(aErrorLogID, aErrorTime, aUserName, aErrorNumber, 0, "N/A", "N/A", 0, "N/A") { }

        public ErrorLog(int aErrorLogID, string aErrorTime, string aUserName, int aErrorNumber, int aErrorSeverity) : this(aErrorLogID, aErrorTime, aUserName, aErrorNumber, aErrorSeverity, "N/A", "N/A", 0, "N/A") { }

        public ErrorLog(int aErrorLogID, string aErrorTime, string aUserName, int aErrorNumber, int aErrorSeverity, string aErrorState) : this(aErrorLogID, aErrorTime, aUserName, aErrorNumber, aErrorSeverity, aErrorState, "N/A", 0, "N/A") { }

        public ErrorLog(int aErrorLogID, string aErrorTime, string aUserName, int aErrorNumber, int aErrorSeverity, string aErrorState, string aErrorProcedure) : this(aErrorLogID, aErrorTime, aUserName, aErrorNumber, aErrorSeverity, aErrorState, aErrorProcedure, 0, "N/A") { }

        public ErrorLog(int aErrorLogID, string aErrorTime, string aUserName, int aErrorNumber, int aErrorSeverity, string aErrorState, string aErrorProcedure, int aErrorLine) : this(aErrorLogID, aErrorTime, aUserName, aErrorNumber, aErrorSeverity, aErrorState, aErrorProcedure, aErrorLine, "N/A") { }

        public ErrorLog(int aErrorLogID, string aErrorTime, string aUserName, int aErrorNumber, int aErrorSeverity, string aErrorState, string aErrorProcedure, int aErrorLine, string aErrorMessage)
        {
            this.ErrorLogId = aErrorLogID;
            this.ErrorTime = aErrorTime;
            this.UserName = aUserName;
            this.ErrorNumber = aErrorNumber;
            this.ErrorSeverity = aErrorSeverity;
            this.ErrorState = aErrorState;
            this.ErrorProcedure = aErrorProcedure;
            this.ErrorLine = aErrorLine;
            this.ErrorMessage = aErrorMessage;
        }
        #endregion

        #region// Display Methods
        public override string ToString()
        {
            string aMessage = "";

            aMessage = aMessage + "Database Log ID: " + ErrorLogId + "\n";
            aMessage = aMessage + "Post Time: " + ErrorTime + "\n";
            aMessage = aMessage + "Database User: " + UserName + "\n";
            aMessage = aMessage + "Event: " + ErrorNumber + "\n";
            aMessage = aMessage + "Schema: " + ErrorSeverity + "\n";
            aMessage = aMessage + "Object: " + ErrorState + "\n";
            aMessage = aMessage + "SQL: " + ErrorProcedure + "\n";
            aMessage = aMessage + "XML Event: " + ErrorLine + "\n";
            aMessage = aMessage + "XML Event: " + ErrorMessage + "\n";

            return aMessage;
        }

        public string Display()
        {
            string aMessage = "";

            aMessage = aMessage + "Database Log ID: " + ErrorLogId + "\n";
            aMessage = aMessage + "Post Time: " + ErrorTime + "\n";
            aMessage = aMessage + "Database User: " + UserName + "\n";
            aMessage = aMessage + "Event: " + ErrorNumber + "\n";
            aMessage = aMessage + "Schema: " + ErrorSeverity + "\n";
            aMessage = aMessage + "Object: " + ErrorState + "\n";
            aMessage = aMessage + "SQL: " + ErrorProcedure + "\n";
            aMessage = aMessage + "XML Event: " + ErrorLine + "\n";
            aMessage = aMessage + "XML Event: " + ErrorMessage + "\n";

            return aMessage;
        }
        #endregion
    }
}