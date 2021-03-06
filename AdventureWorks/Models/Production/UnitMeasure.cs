﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Models.Production
{
    public class UnitMeasure
    {
        private int unitMeasureCode;

        public int UnitMeasureCode
        {
            get { return unitMeasureCode; }
            set { unitMeasureCode = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string modifiedDate;

        public string ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
    }
}