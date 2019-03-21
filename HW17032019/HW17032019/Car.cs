﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17032019
{
    class Car
    {
        public string Brand { get; private set; }
        public bool TotalLost { get; private set; }
        public bool NeedsRepair { get; set; }

        public Car(string brand, bool totalLost, bool needsRepair)
        {
            Brand = brand;
            TotalLost = totalLost;
            NeedsRepair = needsRepair;

            if(totalLost && !needsRepair)
            {
                throw new RepairMismatchException();
            }
           
        }
    }
}
