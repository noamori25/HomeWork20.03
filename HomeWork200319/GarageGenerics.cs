using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork200319
{
    public class GarageGenerics<T> : IGarageGenerics<T> where T : IVehicle
    {
        private List<T> Vehicles;
        private List<string> VehicleTypes;

        public GarageGenerics (List<string> vehicleTypes)
        {
            this.VehicleTypes = new List<string>();
            this.VehicleTypes = vehicleTypes;
            Vehicles = new List<T>();

        }

        public void AddVehicle(T type)
        {
            if (type == null)
            {
                throw new VehicleNullException();
            }
            if (Vehicles.Contains(type))
            {
                throw new VehicleAlreadyHereException();
            }
            if (!type.CanFixTotalLost())
            {
                throw new WeDoNotFixTotalLostException();
            }
            if (!VehicleTypes.Contains(type.Brand))
                    throw new WrongGarageException();
                if (!type.NeedsRepair)
                    throw new RepairMismatchException();
            else
            {
                Vehicles.Add(type);
            }

        }

        public void FixVehicle(T type)
        {
            if (type == null)
            {
                throw new VehicleNullException();
            }
            if (!Vehicles.Contains(type))
            {
                throw new VehicleNotInGarageException();
            }

            if (type.NeedsRepair == false)
                throw new RepairMismatchException();
            else
                type.NeedsRepair = false;
        }

        public void TakeOutVehicle(T type)
        {
            if (type == null)
            {
                throw new VehicleNullException();
            }

            if (!Vehicles.Contains(type))
            {
                throw new VehicleNotInGarageException();
            }

            if (type.NeedsRepair)
              throw new VehicleNotReadyException();
            else
            {
                Vehicles.Remove(type);
            }
        }
    }
}
