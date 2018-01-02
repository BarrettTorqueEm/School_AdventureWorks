using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Purchasing
{
    public class PurchaseOrderHeader
    {
        private int purchaseOrderId;

        public int PurchaseOrderId
        {
            get { return purchaseOrderId; }
            set { purchaseOrderId = value; }
        }

        private int shipMethodId;

        public int ShipMethodId
        {
            get { return shipMethodId; }
            set { shipMethodId = value; }
        }

        private int vendorId;

        public int VendorId
        {
            get { return vendorId; }
            set { vendorId = value; }
        }

        private int revisionNumber;

        public int RevisionNumber
        {
            get { return revisionNumber; }
            set { revisionNumber = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string orderDate;

        public string OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        private string shipDate;

        public string ShipDate
        {
            get { return shipDate; }
            set { shipDate = value; }
        }

        private double subTotal;

        public double SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        private double taxAmt;

        public double TaxAmt
        {
            get { return taxAmt; }
            set { taxAmt = value; }
        }

        private double freight;

        public double Freight
        {
            get { return freight; }
            set { freight = value; }
        }

        private double totalDue;

        public double TotalDue
        {
            get { return totalDue; }
            set { totalDue = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
    }
}