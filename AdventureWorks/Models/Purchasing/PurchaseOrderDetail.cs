using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Purchasing
{
    public class PurchaseOrderDetail
    {
        private int purchaseOrderId;

        public int PurchaseOrderId
        {
            get { return purchaseOrderId; }
            set { purchaseOrderId = value; }
        }

        private int purchaseOrderDetailId;

        public int PurchaseOrderDetailId
        {
            get { return purchaseOrderDetailId; }
            set { purchaseOrderDetailId = value; }
        }

        private string dueDate;

        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        private int orderQty;

        public int OrderQty
        {
            get { return orderQty; }
            set { orderQty = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private double unitPrice;

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        private int lineTotal;

        public int LineTotal
        {
            get { return lineTotal; }
            set { lineTotal = value; }
        }

        private int receivedQty;

        public int ReceivedQty
        {
            get { return receivedQty; }
            set { receivedQty = value; }
        }

        private int rejectedQty;

        public int RejectedQty
        {
            get { return rejectedQty; }
            set { rejectedQty = value; }
        }

        private int stockedQty;

        public int StockedQty
        {
            get { return stockedQty; }
            set { stockedQty = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

    }
}