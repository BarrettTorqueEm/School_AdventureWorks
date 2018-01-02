using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductProductPhoto
    {
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private int productPhotoId;

        public int ProductPhotoId
        {
            get { return productPhotoId; }
            set { productPhotoId = value; }
        }

        private string primary;

        public string Primary
        {
            get { return primary; }
            set { primary = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
    }
}