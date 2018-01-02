using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductModelProductDescriptionCulture
    {
        private int productModelId;

        public int ProductModelId
        {
            get { return productModelId; }
            set { productModelId = value; }
        }

        private int productDescriptionId;

        public int ProductDescriptionId
        {
            get { return productDescriptionId; }
            set { productDescriptionId = value; }
        }

        private int cultureId;

        public int CultureID
        {
            get { return cultureId; }
            set { cultureId = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}