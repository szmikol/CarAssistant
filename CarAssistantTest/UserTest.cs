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
    }
}
