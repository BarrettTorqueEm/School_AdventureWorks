using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SalesTerritoryHistory
    {
        private int businessEntityId;

        public int BusinessEntityId
        {
            get { return businessEntityId; }
            set { businessEntityId = value; }
        }

        private int territoryId;

        public int TerritoryId
        {
            get { return territoryId; }
            set { territoryId = value; }
        }

        private string startDate;

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private string endDate;

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
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