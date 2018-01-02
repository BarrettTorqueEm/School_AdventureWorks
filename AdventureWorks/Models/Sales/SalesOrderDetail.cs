using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SalesOrderDetail
    {
        private int businessEntityId;

        public int BusinessEntityId
        {
            get { return businessEntityId; }
            set { businessEntityId = value; }
        }

        private int salesOrderId;

        public int SalesOrderId
        {
            get { return salesOrderId; }
            set { salesOrderId = value; }
        }

        private int salesOrderDetailId;

        public int SalesOrderDetailId
        {
            get { return salesOrderDetailId; }
            set { salesOrderDetailId = value; }
        }

        private string carrierTrackingNumber;

        public string CarrierTrackingNumber
        {
            get { return carrierTrackingNumber; }
            set { carrierTrackingNumber = value; }
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

        private int specialOfferId;

        public int SpecialOfferId
        {
            get { return specialOfferId; }
            set { specialOfferId = value; }
        }

        private double unitPrice;

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        private double unitPriceDiscount;

        public double UnitPriceDiscount
        {
            get { return unitPriceDiscount; }
            set { unitPriceDiscount = value; }
        }

        private int lineTotal;

        public int LineTotal
        {
            get { return lineTotal; }
            set { lineTotal = value; }
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