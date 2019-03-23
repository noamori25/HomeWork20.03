using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork200319;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Garage g = new Garage(new List<string> { "mazda", "suzuki" });
        GarageGenerics<Bike> gBike = new GarageGenerics<Bike>(new List<string> { "mazda", "bmw" });
        Car c = new Car("volvo", false, true);
        Bike b = new Bike("volvo", 2500, true, true);

        //Add functions

        [TestMethod]
        [ExpectedException(typeof(WrongGarageException))]
        public void AddCarMethodIsWrongGarageExcepion()
        {
            g.AddCar(c);
        }
           

        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void AddCarMethodIsCarNullException()
        {
            c = null;
            g.AddCar(c);
        }

        [TestMethod]
        [ExpectedException(typeof(CarAlreadyHereException))]
        public void AddCarMethodIsCarAlreadyHereException()
        {
            Car c = new Car("mazda", false, true);
            g.AddCar(c);
            g.AddCar(c);
        }

        [TestMethod]
        [ExpectedException(typeof(WeDoNotFixTotalLostException))]
        public void AddCarMethodIsWeDoNotFixTotalLostException()
        {
            Car c = new Car("mazda", true, true);
            g.AddCar(c);
        }

        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void AddCarMethodIsRepairMismatchException()
        {
            Car c = new Car("mazda", false, false);
           g.AddCar(c);
        }

        [TestMethod]
        public void AddCarMethod()
        {
            Car c = new Car("mazda", false, true);
            Bike b = new Bike("bmw", 2500, true, true);
            g.AddCar(c);
            gBike.AddVehicle(b);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongGarageException))]
        public void AddVehicleMethodIsWrongGarageExcepion()
        {
            gBike.AddVehicle(b);
        }

        [TestMethod]
        [ExpectedException(typeof(VehicleNullException))]
        public void AddVehicleMethodIsCarNullException()
        {
            b = null;
            gBike.AddVehicle(b);
        }

        [TestMethod]
        [ExpectedException(typeof(VehicleAlreadyHereException))]
        public void AddVehicleMethodIsCarAlreadyHereException()
        {
            Bike b = new Bike("bmw", 2500, true, true);
            gBike.AddVehicle(b);
            gBike.AddVehicle(b);

        }


        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void AddVehicleMethodIsRepairMismatchException()
        {
            Bike b = new Bike("bmw", 2300, false, false);
            gBike.AddVehicle(b);
        }

        [TestMethod]
        public void AddVehicleMethod()
        {
            Bike b = new Bike("bmw", 2500, true, true);
            gBike.AddVehicle(b);
        }

        //fix functions

        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void FixCarMethodIsCarNullException()
        {
            Car c = null;
            g.FixCar(c);
        }

        [TestMethod]
        [ExpectedException(typeof(CarNotInGarageException))]
        public void FixCarMethodIsCarNotInGarageException()
        {
            Car c = new Car("mazda", false, true);
            g.FixCar(c);

        }

        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void FixCarMethodIsRepairMismatchException()
        {
            Car c = new Car("mazda", false, false);
            g.AddCar(c);
            g.FixCar(c);

        }

        [TestMethod]
        public void FixCarMethod()
        {
            Car c = new Car("mazda", false, true);
            g.AddCar(c);
            g.FixCar(c);
        }

        [TestMethod]
        [ExpectedException(typeof(VehicleNullException))]
        public void FixVehicleMethodIsCarNullException()
        {
            b = null;
            gBike.FixVehicle(b);
        }

        [TestMethod]
        [ExpectedException(typeof(VehicleNotInGarageException))]
        public void FixVehicleMethodIsCarNotInGarageException()
        {
            Bike b = new Bike("mazda", 1200, false, true);
            gBike.FixVehicle(b);
            

        }

        [TestMethod]
        [ExpectedException(typeof(RepairMismatchException))]
        public void FixVehicleMethodIsRepairMismatchException()
        {
            Bike b = new Bike("volvo", 1200, true, false);
            gBike.FixVehicle(b);
        }

        [TestMethod]
        public void FixVehicleMethod()
        {
            Bike b = new Bike("bmw", 1200, true, true);
            gBike.AddVehicle(b);
            gBike.FixVehicle(b);
        }

        //take out functions

        [TestMethod]
        [ExpectedException(typeof(CarNullException))]
        public void TakeCarOutMethodIsCarNullException()
        {
            Car c = null;
            g.TakeOutCar(c);

        }

        [TestMethod]
        [ExpectedException(typeof(CarNotInGarageException))]
        public void TakeCarOutMethodIsCarNotInGarageException()
        {
            Car c = new Car("mazda", false, true);
            g.TakeOutCar(c);

        }

        [TestMethod]
        [ExpectedException(typeof(CarNotReadyException))]
        public void TakeCarOutMethodIsCarNotReadyException()
        {
            Car c = new Car("mazda", false, true);
            g.AddCar(c);
            g.TakeOutCar(c);

        }

        [TestMethod]
        public void TakeCarOutMethod()
        {
            Car c = new Car("mazda", false, true);
            g.AddCar(c);
            g.FixCar(c);
            g.TakeOutCar(c);
        }

        [TestMethod]
        [ExpectedException(typeof(VehicleNullException))]
        public void TakeVehicleOutMethodIsCarNullException()
        {
            b = null;
            gBike.TakeOutVehicle(b);
        }

        [TestMethod]
        [ExpectedException(typeof(VehicleNotInGarageException))]
        public void TakeVehicleOutMethodIsCarNotInGarageException()
        {
            Bike b = new Bike("bmw", 1800, false, true);
            gBike.TakeOutVehicle(b);
             
        }

        [TestMethod]
        [ExpectedException(typeof(VehicleNotReadyException))]
        public void TakeVehicleOutMethodIsCarNotReadyException()
        {
            Bike b = new Bike("bmw", 2500, true, true);
            gBike.AddVehicle(b);
            gBike.TakeOutVehicle(b);
        }

        [TestMethod]
        public void TakeVehicleOutMethod()
        {
            Bike b = new Bike("bmw", 2500, true, true);
            gBike.AddVehicle(b);
            gBike.FixVehicle(b);
            gBike.TakeOutVehicle(b);
        }
    }
}
