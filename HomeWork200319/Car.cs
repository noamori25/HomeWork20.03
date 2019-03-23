using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork200319
{
    public class Car : IVehicle
    {
        public string Brand { get; private set; }
        public bool TotalLost { get; private set; }
        public bool NeedsRepair { get; set; }

        public Car (string brand, bool totalLost, bool needsRepair)
        {
            this.Brand = brand;
            this.TotalLost = totalLost;
            this.NeedsRepair = needsRepair;

            if (totalLost && !needsRepair)
            {
                throw new RepairMismatchException();
            }
        }

        public bool CanFixTotalLost()
        {
            return false;
        }
    }
}
