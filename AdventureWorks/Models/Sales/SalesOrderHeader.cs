using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Sales
{
    public class SalesOrderHeader
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

        private int shipMethodId;

        public int ShipMethodId
        {
            get { return shipMethodId; }
            set { shipMethodId = value; }
        }

        private int revisionNumber;

        public int RevisionNumber
        {
            get { return revisionNumber; }
            set { revisionNumber = value; }
        }

        private string orderDate;

        public string OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        private string dueDate;

        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        private string shipDate;

        public string ShipDate
        {
            get { return shipDate; }
            set { shipDate = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string onlineOrderFlag;

        public string OnlineOrderFlag
        {
            get { return onlineOrderFlag; }
            set { onlineOrderFlag = value; }
        }

        private int salesOrderNumber;

        public int SalesOrderNumber
        {
            get { return salesOrderNumber; }
            set { salesOrderNumber = value; }
        }

        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private int territoryId;

        public int TerritoryId
        {
            get { return territoryId; }
            set { territoryId = value; }
        }

        private int billToAddressId;

        public int BillToAddressId
        {
            get { return billToAddressId; }
            set { billToAddressId = value; }
        }

        private int shipToAddressId;

        public int ShipToAddressId
        {
            get { return shipToAddressId; }
            set { shipToAddressId = value; }
        }

        private int creditCardId;

        public int CreditCardId
        {
            get { return creditCardId; }
            set { creditCardId = value; }
        }

        private int creditCardApprovalCode;

        public int CreditCardApprovalCode
        {
            get { return creditCardApprovalCode; }
            set { creditCardApprovalCode = value; }
        }

        private int currencyRateId;

        public int CurrencyRateId
        {
            get { return currencyRateId; }
            set { currencyRateId = value; }
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

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
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