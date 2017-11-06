using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;

namespace CarAssistant
{
	public class User : IUser
	{
        /// <summary>
        /// Full name of the user: "Name Surname".
        /// </summary>
        public string name;
        /// <summary>
        /// User's birth date: DD-MM-YYYY.
        /// </summary>
        public DateTime birthDate;
        /// <summary>
        /// Number of user's identity document.
        /// </summary>
        public int idNumber;
        /// <summary>
        /// Number of user's driving licence.
        /// </summary>
        public int licenceNumber;
        /// <summary>
        /// Date of issue of the driver's licence
        /// </summary>
        public DateTime licenceDate;
        /// <summary>
        /// Legal residence address in format: "street,post code, city".
        /// </summary>
        public string residenceAddress;
        /// <summary>
        /// List of cars owned by user.
        /// </summary>
        public List<Car> userCars;


        /// <summary>
        /// Method adds new car to the user's car list "userCars".
        /// </summary>
        /// <param name="NewCar"></param>
		public void AddNewCar(Car NewCar)
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// Finds car in user's car list by Brand, Model and ProductionYear.
        /// </summary>
        /// <param name="Brand"></param>
        /// <param name="Model"></param>
        /// <param name="ProductionYear"></param>
        /// <returns></returns>
		public Car FindCar(Brand Brand, Model Model, int ProductionYear)
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// Removes car from user's car list by Brand, Model, ProductionYear.
        /// </summary>
        /// <param name="Brand"></param>
        /// <param name="Model"></param>
        /// <param name="ProductionYear"></param>
		public void RemoveCar(Brand Brand, Model Model, int ProductionYear)
		{
			throw new NotImplementedException();
		}

        /// <summary>
        /// Returns user's car list "userCars".
        /// </summary>
        /// <returns></returns>
		public List<Car> retrieveCars()
		{
            return userCars;
		}

        /// <summary>
        /// Writes short description of a user. Name, age, number of owned cars.
        /// </summary>
        /// <returns></returns>
		public string WriteUserShortDescription()
		{
			throw new NotImplementedException();
		}
	}
}
