using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork200319
{
    interface IGarage
    {
        void AddCar(Car c);

        void TakeOutCar(Car c);

        void FixCar(Car c);

    }
}
