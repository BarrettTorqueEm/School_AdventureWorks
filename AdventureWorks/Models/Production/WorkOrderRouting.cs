using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class WorkOrderRouting
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

        private string operationSequence;

        public string OperationSequence
        {
            get { return operationSequence; }
            set { operationSequence = value; }
        }

        private int locationId;

        public int LocationId
        {
            get { return locationId; }
            set { locationId = value; }
        }

        private string scheduledStartDate;

        public string ScheduledStartDate
        {
            get { return scheduledStartDate; }
            set { scheduledStartDate = value; }
        }

        private string scheduledEndDate;

        public string ScheduledEndDate
        {
            get { return scheduledEndDate; }
            set { scheduledEndDate = value; }
        }

        private string actualStartDate;

        public string ActualStartDate
        {
            get { return actualStartDate; }
            set { actualStartDate = value; }
        }

        private string actualEndDate;

        public string ActualEndDate
        {
            get { return actualEndDate; }
            set { actualEndDate = value; }
        }

        private int actualResourceHrs;

        public int ActualResourceHrs
        {
            get { return actualResourceHrs; }
            set { actualResourceHrs = value; }
        }

        private double plannedCost;

        public double PlannedCost
        {
            get { return plannedCost; }
            set { plannedCost = value; }
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
    }
}