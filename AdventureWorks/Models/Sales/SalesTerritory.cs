using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SalesTerritory
    {
        private int territoryId;

        public int TerritoryId
        {
            get { return territoryId; }
            set { territoryId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string countryRegionCode;

        public string CountryRegionCode
        {
            get { return countryRegionCode; }
            set { countryRegionCode = value; }
        }

        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; }
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

        private double costYTD;

        public double CostYTD
        {
            get { return costYTD; }
            set { costYTD = value; }
        }

        private double costLastYear;

        public double CostLastYear
        {
            get { return costLastYear; }
            set { costLastYear = value; }
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