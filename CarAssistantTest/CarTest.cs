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

			Assert.AreEqual(17, result);
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
        public void AddExpenseTest()
        {
            Repairs repair1 = new Repairs(1250M, "Uszczelka pod głowica", new DateTime(2017, 12, 01), "U pana Stasia");
            Insurance insurance1 = new Insurance(1500M, "OC", new DateTime(2017, 05, 11), true, new DateTime(2018, 05, 10), "PSU S.A.");
            Service service = new Service(750M, "Distribution system fix", new DateTime(2017, 12, 01), "Zenek Serwis");
            LooksMaintenance looks1 = new LooksMaintenance(12.50M, "Pranie tapicerki", new DateTime(2017, 12, 01), "Added wunderbaum");
            Exploitation explo1 = new Exploitation(1250M, "Tyres changed", new DateTime(2017, 12, 01), "355/25R1 107 Y Pirelli PZERO");

            User user = new User();
            Car car1 = CreateNewCarBrandModelYear("Alfa Romeo", "159", new DateTime(2005, 01, 01));
            Car car2 = CreateNewCarBrandModelYear("BMW", "I8", new DateTime(2010, 01, 01));
            Car car3 = CreateNewCarBrandModelYear("Merol", "Jakiś", new DateTime(2015, 01, 01));
            user.AddNewCar(car1);
            user.AddNewCar(car2);
            user.AddNewCar(car3);

            user.userCars[1].expenses.Add(repair1);
            user.userCars[2].expenses.Add(insurance1);
            user.userCars[1].expenses.Add(explo1);

            List<object> list = user.userCars[1].expenses;
            Assert.AreEqual(2, list.Count());
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
