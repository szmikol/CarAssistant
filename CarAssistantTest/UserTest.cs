using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant;

namespace CarAssistantTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void GetUserAgeTest()
        {
            //Arrange
            User user = new User();
            user.SetBirthdate(new DateTime(1993, 04, 11));
            //Act
            int result = user.GetUserAge();
            //Assert
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GetResidenceAddressTest()
        {
            User user = new User();

            user.SetResidenceAddress("street", "postCode", "city");
            var result = user.GetResidenceAddress();

            Assert.AreEqual("street,postCode,city", result);

        }

        [TestMethod]
        public void FindCarByBrandModelProductionYear()
        {
            List<Car> testcar = new List<Car>();
            User user = new User();

            Car car1 = CreateNewCarBrandModelYear("Alfa Romeo", "159", new DateTime(2005, 01, 01));
            Car car2 = CreateNewCarBrandModelYear("BMW", "I8", new DateTime(2010, 01, 01));
            Car car3 = CreateNewCarBrandModelYear("Merol", "Jakiś", new DateTime(2015, 01, 01));
            user.AddNewCar(car1);
            user.AddNewCar(car2);
            user.AddNewCar(car3);
            testcar = user.FindCar("BMW", "I8", 2010);

            Assert.AreEqual(testcar[0], car2);
        }

        [TestMethod]
        public void RemoveCarByVin()
        {
            User user = new User();
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            car1.SetVin("TestVin1");
            car2.SetVin("TestVin2");
            car3.SetVin("TestVin3");
            user.AddNewCar(car1);
            user.AddNewCar(car2);
            user.AddNewCar(car3);
            user.RemoveCar("TestVin2");

            Assert.AreEqual(2, user.UserCars.Count());
        }
        [TestMethod]
        public void RemoveCarCheckingIndexes()
        {
            User user = new User();
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            car1.SetVin("TestVin1");
            car2.SetVin("TestVin2");
            car3.SetVin("TestVin3");
            user.AddNewCar(car1);
            user.AddNewCar(car2);
            user.AddNewCar(car3);
            user.RemoveCar("TestVin2");

            Assert.AreEqual(user.UserCars[1], car3);
        }


        private Car CreateNewCarBrandModelYear(string brand, string model, DateTime productionYear)
        {
            Car car = new Car();
            car.Brand = brand;
            car.Model = model;
            car.ProductionDate = productionYear;
            return car;
        }
    }
}
