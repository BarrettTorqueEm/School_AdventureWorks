using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class Document
    {
        #region//Initalizing Variables
        private string documentNode = "N/A";
        private string documentLevel = "N/A";
        private string title = "N/A";
        private string owner = "N/A";
        private string folderFlag = "N/A";
        private string fileName = "N/A";
        private string fileExtension = "N/A";
        private string revision = "N/A";
        private int changeNumber = 0;
        private string status = "N/A";
        private string documentSummary = "N/A";
        private string aDocument = "N/A";
        private string rowguid = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public string DocumentNode
        {
            get
            {
                return this.documentNode;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.documentNode = null;
                }
                else
                {
                    this.documentNode = value;
                }
            }
        }

        public string DocumentLevel
        {
            get
            {
                return this.documentLevel;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.documentLevel = null;
                }
                else
                {
                    this.documentLevel = value;
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

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.owner = null;
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public string FolderFlag
        {
            get
            {
                return this.folderFlag;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.folderFlag = null;
                }
                else
                {
                    this.folderFlag = value;
                }
            }
        }

        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.fileName = null;
                }
                else
                {
                    this.fileName = value;
                }
            }
        }

        public string FileExtension
        {
            get
            {
                return this.fileExtension;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.fileExtension = null;
                }
                else
                {
                    this.fileExtension= value;
                }
            }
        }

        public string Revision
        {
            get
            {
                return this.revision;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.revision = null;
                }
                else
                {
                    this.revision = value;
                }
            }
        }

        public int ChangeNumber
        {
            get
            {
                return this.changeNumber;
            }
            set
            {
                if (value > 0)
                {
                    this.changeNumber = value;
                }
            }
        }

        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.status = null;
                }
                else
                {
                    this.status = value;
                }
            }
        }

        public string DocumentSummary
        {
            get
            {
                return this.documentSummary;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.documentSummary= null;
                }
                else
                {
                    this.documentSummary = value;
                }
            }
        }

        public string ADocument
        {
            get
            {
                return this.aDocument;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.aDocument = null;
                }
                else
                {
                    this.aDocument = value;
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