using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class TransactionHistory
    {
        private int transactionId;

        public int TransactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private int referenceOrderId;

        public int ReferenceOrderId
        {
            get { return referenceOrderId; }
            set { referenceOrderId = value; }
        }

        private string transactionDate;

        public string TranscationDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }

        private string transactionType;

        public string TransactionType
        {
            get { return transactionType;}
            set { transactionType = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private double actualCost;

        public double ActualCost
        {
            get { return actualCost; }
            set { actualCost = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

        private int referenceOrderLineId;

        public int ReferenceOrderLineId
        {
            get { return referenceOrderLineId; }
            set { referenceOrderLineId = value; }
        }
    }
}