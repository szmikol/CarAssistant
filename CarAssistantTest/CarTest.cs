using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant;
using CarAssistant.Classes.Expenses;

namespace CarAssistantTest
{
	[TestClass]
	public class CarTest
	{
		[TestMethod]
		public void CalculateAgeTest()
		{
			Car car = new Car();
			DateTime date = new DateTime();
            date = DateTime.Parse("01.01.2000");

            car.ProductionDate = date;

			int result = car.CalculateAge();

			Assert.AreEqual(18, result);
		}

		[TestMethod]
		public void CalculateAgeTest_NoProductionDate()
		{
            /*Car car = new Car();
            DateTime date = new DateTime();
            date = DateTime.Parse("01.01.0000");
            car.SetProductionDate(date);
			int result = car.CalculateAge();

			Assert.AreEqual(0, result);*/
        }

        [TestMethod]
        public void AddRepairsTest()
        {
            Exploitation explo1 = new Exploitation(1250M, "Tyres changed", new DateTime(2017, 12, 01), "355/25R1 107 Y Pirelli PZERO");
            Insurance insurance1 = new Insurance(1500M, "OC", new DateTime(2017, 05, 11), true, new DateTime(2018, 05, 10), "PZU S.A.");
            LooksMaintenance looks1 = new LooksMaintenance(12.50M, "Pranie tapicerki", new DateTime(2017, 12, 01), "Added wunderbaum");
            Repairs repair1 = new Repairs(1250M, "Uszczelka pod głowica", new DateTime(2017, 12, 01), "U pana Stasia");
            Service service1 = new Service(750M, "Distribution system fix", new DateTime(2017, 12, 01), "Zenek Serwis");

            User user = new User();
            Car car1 = CreateNewCarBrandModelYear("Alfa Romeo", "159", new DateTime(2005, 01, 01));
            Car car2 = CreateNewCarBrandModelYear("BMW", "I8", new DateTime(2010, 01, 01));
            user.AddNewCar(car1);
            user.AddNewCar(car2);

            //user.UserCars[1].Exploitation.Add(explo1);
            //user.UserCars[1].Insurance.Add(insurance1);
            //user.UserCars[1].LooksMaintenance.Add(looks1);
            //user.UserCars[1].Repairs.Add(repair1);
            //user.UserCars[1].Services.Add(service1);

            //Assert.AreEqual(1, user.UserCars[1].Exploitation.Count());
            //Assert.AreEqual(1, user.UserCars[1].Insurance.Count());
            //Assert.AreEqual(1, user.UserCars[1].LooksMaintenance.Count());
            //Assert.AreEqual(1, user.UserCars[1].Repairs.Count());
            //Assert.AreEqual(1, user.UserCars[1].Insurance.Count());
        }


        private Car CreateNewCarBrandModelYear(string brand, string model, DateTime productionYear)
        {
            Car car = new Car();
            car.Brand = brand;
            car.Model = model;
            car.ProductionDate = productionYear;
            //car.Exploitation = new List<Exploitation>();
            //car.Insurance = new List<Insurance>();
            //car.LooksMaintenance = new List<LooksMaintenance>();
            //car.Repairs = new List<Repairs>();
            //car.Services = new List<Service>();
            return car;
        }

        
    }
}
