using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Classes;
using CarAssistant.Interfaces;

namespace CarAssistant
{
	public class CarManager : ICarManager
	{
		public void CreateNewCar(User WhichUser, Car NewCar)
		{
			throw new NotImplementedException();
		}

		public void DeleteCar(User WhichUser, Car CarToDelete)
		{
			throw new NotImplementedException();
		}

		public void DeleteCarById(User WhichUser, int Id)
		{
			throw new NotImplementedException();
		}

		public void DeleteCarByModel(User WhichUser, Brand Brand, Model CarModel)
		{
			throw new NotImplementedException();
		}

		public Car FindCarById(User WhichUser, int Id)
		{
			throw new NotImplementedException();
		}

		public List<Car> FindCardByModel(User WhichUser, Model CarModel)
		{
			throw new NotImplementedException();
		}

		public List<Car> FindCarsByBrand(User WhichUser, Brand CarBrand)
		{
			throw new NotImplementedException();
		}

		public Dictionary<Brand, Model> RetrieveAllCarsOfSpecificBrand(User WhichUser, Brand CarBrand)
		{
			throw new NotImplementedException();
		}

		public Car UpdateCar(User WhichUser, Car UpdatedCar)
		{
			throw new NotImplementedException();
		}
	}
}
