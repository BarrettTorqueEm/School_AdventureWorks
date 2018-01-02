using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductPhoto
    {
        private int productPhotoId;

        public int ProductPhotoId
        {
            get { return productPhotoId; }
            set { productPhotoId = value; }
        }

        private string thumbNailPhoto;

        public string ThumbNailPhoto
        {
            get { return thumbNailPhoto; }
            set { thumbNailPhoto = value; }
        }

        private string thumbNailPhotoFileName;

        public string ThumbNailPhotoFileName
        {
            get { return thumbNailPhotoFileName; }
            set { thumbNailPhotoFileName = value; }
        }

        private string largePhoto;

        public string LargePhoto
        {
            get { return largePhoto; }
            set { largePhoto = value; }
        }

        private string largePhotoFileName;

        public string LargePhotoFileName
        {
            get { return largePhotoFileName; }
            set { largePhotoFileName = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
    }
}