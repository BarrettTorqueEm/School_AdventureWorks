using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class ProductReview
    {
        private int productReviewId;

        public int ProductReviewId
        {
            get { return productReviewId; }
            set { productReviewId = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private string reviewerName;

        public string ReviewerName
        {
            get { return reviewerName; }
            set { reviewerName = value; }
        }

        private string reviewDate;

        public string ReviewDate
        {
            get { return reviewDate; }
            set { reviewDate = value; }
        }

        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private int rating;

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        private string comments;

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}