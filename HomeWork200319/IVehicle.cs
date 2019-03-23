using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork200319
{
     public interface IVehicle : IIFixTotalLost
    {
       string Brand { get; }
       bool TotalLost { get;}
       bool NeedsRepair { get; set; }
    }
}
