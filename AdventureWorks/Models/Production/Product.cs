using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class Product
    {
        #region//Initalizing Variables
        private int productId = 0;
        private string name = "N/A";
        private int productNumber = 0;
        private string makeFlag = "N/A";
        private string finishedGoodsFlag = "N/A";
        private string color = "N/A";
        private int safetyStockLevel = 0;
        private string reorderPoint = "N/A";
        private double standardCost = 0.0;
        private double listPrice = 0.0;
        private string size = "N/A";
        private int sizeUnitMeasureCode = 0;
        private int weightUnitMeasureCode = 0;
        private double weight = 0.0;
        private int daysToManufacture = 0;
        private string productLine = "N/A";
        private string aClass = "N/A";
        private string style = "N/A";
        private int productSubcategoryId = 0;
        private int productModelId = 0;
        private string sellStartDate = "N/A";
        private string sellEndDate = "N/A";
        private string discontinuedDate = "N/A";
        private string rowguid = "N/A";
        private string modifiedDate = "N/A";
        #endregion

        #region//Gets and Sets
        public int ProductId
        {
            get
            {
                return this.productId;
            }
            set
            {
                if (value > 0)
                {
                    this.productId = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.name = null;
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int ProductNumber
        {
            get
            {
                return this.productNumber;
            }
            set
            {
                if (value > 0)
                {
                    this.productNumber = value;
                }
            }
        }

        public string MakeFlag
        {
            get
            {
                return this.makeFlag;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.makeFlag = null;
                }
                else
                {
                    this.makeFlag = value;
                }
            }
        }

        public string FinishedGoodsFlag
        {
            get
            {
                return this.finishedGoodsFlag;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.finishedGoodsFlag = null;
                }
                else
                {
                    this.finishedGoodsFlag = value;
                }
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.color = null;
                }
                else
                {
                    this.color = value;
                }
            }
        }

        public int SafetyStockLevel
        {
            get
            {
                return this.safetyStockLevel;
            }
            set
            {
                if (value > 0)
                {
                    this.safetyStockLevel = value;
                }
            }
        }

        public string ReorderPoint
        {
            get
            {
                return this.reorderPoint;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.reorderPoint = null;
                }
                else
                {
                    this.reorderPoint = value;
                }
            }
        }

        public double StandardCost
        {
            get
            {
                return this.standardCost;
            }
            set
            {
                if (value > 0)
                {
                    this.standardCost = value;
                }
            }
        }

        public double ListPrice
        {
            get
            {
                return this.listPrice;
            }
            set
            {
                if (value > 0)
                {
                    this.listPrice = value;
                }
            }
        }

        public string Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.size = null;
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int SizeUnitMeasureCode
        {
            get
            {
                return this.sizeUnitMeasureCode;
            }
            set
            {
                if (value > 0)
                {
                    this.sizeUnitMeasureCode = value;
                }
            }
        }

        public int WeightUnitMeasureCode
        {
            get
            {
                return this.weightUnitMeasureCode;
            }
            set
            {
                if (value > 0)
                {
                    this.weightUnitMeasureCode = value;
                }
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if(value > 0)
                {
                    this.weight = value;
                }
            }
        }   

        public int DaysToManufacture
        {
            get
            {
                return this.daysToManufacture;
            }
            set
            {
                if (value > 0)
                {
                    this.daysToManufacture = value;
                }
            }
        }

        public string ProductLine
        {
            get
            {
                return this.productLine;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.productLine = null;
                }
                else
                {
                    this.productLine = value;
                }
            }
        }

        public string AClass
        {
            get
            {
                return this.aClass;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.aClass = null;
                }
                else
                {
                    this.aClass = value;
                }
            }
        }

        public string Style
        {
            get
            {
                return this.style;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.style = null;
                }
                else
                {
                    this.style = value;
                }
            }
        }

        public int ProductSubcategoryId
        {
            get
            {
                return this.productSubcategoryId;
            }
            set
            {
                if (value > 0)
                {
                    this.productSubcategoryId = value;
                }
            }
        }

        public int ProductModelId
        {
            get
            {
                return this.productModelId;
            }
            set
            {
                if (value > 0)
                {
                    this.productModelId = value;
                }
            }
        }

        public string SellStartDate
        {
            get
            {
                return this.sellStartDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.sellStartDate = null;
                }
                else
                {
                    this.sellStartDate = value;
                }
            }
        }

        public string SellEndDate
        {
            get
            {
                return this.sellEndDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.sellEndDate = null;
                }
                else
                {
                    this.sellEndDate = value;
                }
            }
        }

        public string DiscontinuedDate
        {
            get
            {
                return this.discontinuedDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.discontinuedDate = null;
                }
                else
                {
                    this.discontinuedDate = value;
                }
            }
        }

        public string Rowguid
        {
            get
            {
                return this.rowguid;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.rowguid = null;
                }
                else
                {
                    this.rowguid = value;
                }
            }
        }

        public string ModifiedDate
        {
            get
            {
                return this.modifiedDate;
            }
            set
            {
                if (value.Length < 1)
                {
                    this.modifiedDate = null;
                }
                else
                {
                    this.modifiedDate = value;
                }
            }
        }
        #endregion
    }
}