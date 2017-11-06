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

		public void AddNewCar(Car NewCar)
		{
			throw new NotImplementedException();
		}

		public Car FindCar(Brand Brand, Model Model, int ProductionYear)
		{
			throw new NotImplementedException();
		}

		public void RemoveCar(Brand Brand, Model Model, int ProductionYear)
		{
			throw new NotImplementedException();
		}

		public List<Car> retrieveCars()
		{
			throw new NotImplementedException();
		}

		public string WriteUserShortDescription()
		{
			throw new NotImplementedException();
		}
	}
}
