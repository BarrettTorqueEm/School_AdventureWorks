using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Purchasing
{
    public class ShipMethod
    {
        private int shipMethodId;

        public int ShipMethodId
        {
            get { return shipMethodId; }
            set { shipMethodId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double shipBase;

        public double ShipBase
        {
            get { return shipBase; }
            set { shipBase = value; }
        }

        private double shipRate;

        public double ShipRate
        {
            get { return shipRate; }
            set { shipRate = value; }
        }

        private string rowguid;

        public string Rowguid
        {
            get { return rowguid; }
            set { rowguid = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}