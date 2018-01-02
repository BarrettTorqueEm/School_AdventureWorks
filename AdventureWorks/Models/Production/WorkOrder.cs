using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class WorkOrder
    {
        private int workOrderId;

        public int WorkOrderId
        {
            get { return workOrderId; }
            set { workOrderId = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private int orderQty;

        public int OrderQty
        {
            get { return orderQty; }
            set { orderQty = value; }
        }

        private int stockedQty;

        public int StockedQty
        {
            get { return stockedQty; }
            set { stockedQty = value; }
        }

        private int scrappedQty;

        public int ScrappedQty
        {
            get { return scrappedQty; }
            set { scrappedQty = value; }
        }

        private string startDate;

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private string endDate;

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private string dueDate;

        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        private int scrapReasonId;

        public int ScrapReasonId
        {
            get { return scrapReasonId; }
            set { scrapReasonId = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
    }
}