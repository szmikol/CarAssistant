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
	public class CarTest
	{
		[TestMethod]
		public void CalculateAgeTest()
		{
			Car car = new Car();
			DateTime date = new DateTime();
            date = DateTime.Parse("01.01.2000");

			car.SetProductionDate(date);

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
    }
}
