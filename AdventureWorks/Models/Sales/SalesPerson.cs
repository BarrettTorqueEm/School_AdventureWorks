using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SalesPerson
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

        private string salesQuota;

        public string SalesQuota
        {
            get { return salesQuota; }
            set { salesQuota = value; }
        }

        private string bonus;

        public string Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        private string commissionPct;

        public string CommissionPct 
        {
            get { return commissionPct; }
            set { commissionPct = value; }
        }

        private int salesYTD;

        public int SalesYTD
        {
            get { return salesYTD; }
            set { salesYTD = value; }
        }

        private int salesLastYear;

        public int SalesLastYear
        {
            get { return salesLastYear; }
            set { salesLastYear = value; }
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