using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductModelIllustration
    {
        private int productModelId;

        public int ProductModelId
        {
            get { return productModelId; }
            set { productModelId = value; }
        }

        private int illustrationId;

        public int IllustrationId
        {
            get { return illustrationId; }
            set { illustrationId = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}