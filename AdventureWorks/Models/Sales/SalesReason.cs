using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SalesReason
    {
        private int salesReasonId;

        public int SalesReasonId
        {
            get { return salesReasonId; }
            set { salesReasonId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string reasonType;

        public string ReasonType
        {
            get { return reasonType; }
            set { reasonType = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
    }
}