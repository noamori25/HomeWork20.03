using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork200319
{
   public class Bike : IVehicle
    {
        public string Brand { get; private set; }
         public  bool TotalLost { get; private set; }
         public bool NeedsRepair { get; set; }
        public int EngineVolume { get; private set; }
     

        public Bike(string brand,int engineVolume, bool totalLost, bool needsRepair)
        {
            this.Brand = brand;
            this.EngineVolume = engineVolume;
            this.TotalLost = totalLost;
            this.NeedsRepair = needsRepair;

            if (!needsRepair)
            {
                throw new RepairMismatchException();
            }
        }

        public bool CanFixTotalLost()
        {
            return true;
        }

  
    }
}
