using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork200319
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage g = new Garage(new List<string>() { "honda", "suzuki" });
            //g.AddCar(null);
            Car c = new Car("honda", false, true);
            g.AddCar(c);
            g.AddCar(c);
            g.AddCar(new Car ("honda",false,true));
            g.AddCar(new Car("honda", false, true));

        }
    }
}
