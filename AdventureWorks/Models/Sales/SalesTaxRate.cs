using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SalesTaxRate
    {
        private int salesTaxRateId;

        public int SalesTaxRateId
        {
            get { return salesTaxRateId; }
            set { salesTaxRateId = value; }
        }

        private int stateProvinceId;

        public int StateProvinceId
        {
            get { return stateProvinceId; }
            set { stateProvinceId = value; }
        }

        private string taxType;

        public string TaxType
        {
            get { return taxType; }
            set { taxType = value; }
        }

        private double taxRate;

        public double TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
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