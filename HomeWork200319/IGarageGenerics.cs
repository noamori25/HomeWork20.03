using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork200319
{
   public interface IGarageGenerics<T>
    {
        void AddVehicle(T type);

        void TakeOutVehicle(T type);

        void FixVehicle(T type);

    }
}
