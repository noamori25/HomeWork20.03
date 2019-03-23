using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork200319
{
   public class Garage : IGarage
    {
        private List<Car> cars;
        private List<string> carTypes;

        public Garage (List<string> carTypes)
        {
            this.carTypes = new List<string>();
            this.carTypes = carTypes;
            cars = new List<Car>();

        }

        public void AddCar(Car c)
        {
            if (c == null)
            {
                throw new CarNullException();
            }
            if (cars.Contains(c))
            {
                throw new CarAlreadyHereException();
            }

            if (c.TotalLost)
            {
                throw new WeDoNotFixTotalLostException();
            }

            if (!carTypes.Contains(c.Brand))
            {
                throw new WrongGarageException();
            }

            if (!c.NeedsRepair)
            {
                throw new RepairMismatchException();
            }

            else
            {
                cars.Add(c);
            }

        }

        public void FixCar(Car c)
        {
            if (c == null)
            {
                throw new CarNullException();
            }
            if (!cars.Contains(c))
            {
                throw new CarNotInGarageException();
            }

            if (c.NeedsRepair == false)
            {
                throw new RepairMismatchException();
            }
            else
            {
                c.NeedsRepair = false;
            }
        }

        public void TakeOutCar(Car c)
        {
            if (c == null)
            {
                throw new CarNullException();
            }

            if (!cars.Contains(c))
            {
                throw new CarNotInGarageException();
            }

            if (c.NeedsRepair)
            {
                throw new CarNotReadyException();
            }

            else
            {
                cars.Remove(c);
            }
        }
    }
}
