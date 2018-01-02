using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductSubcategory
    {
        private int productSubcategoryId;

        public int ProductSubcategoryId
        {
            get { return productSubcategoryId; }
            set { productSubcategoryId = value; }
        }

        private int productCategoryId;

        public int ProductCategoryId
        {
            get { return productCategoryId; }
            set { productCategoryId = value; }
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

        public string ModifedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
    }
}