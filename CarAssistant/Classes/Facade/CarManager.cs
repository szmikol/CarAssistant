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
		public void CreateNewCar(Car NewCar)
		{
			throw new NotImplementedException();
		}

		public void DeleteCar(Car CarToDelete)
		{
			throw new NotImplementedException();
		}

		public void DeleteCarById(int Id)
		{
			throw new NotImplementedException();
		}

		public void DeleteCarByModel(Brand Brand, Model CarModel)
		{
			throw new NotImplementedException();
		}

		public Car FindCarById(int Id)
		{
			throw new NotImplementedException();
		}

		public List<Car> FindCardByModel(Model CarModel)
		{
			throw new NotImplementedException();
		}

		public List<Car> FindCarsByBrand(Brand CarBrand)
		{
			throw new NotImplementedException();
		}

		public Dictionary<Brand, Model> RetrieveAllCarsOfSpecificBrand(Brand CarBrand)
		{
			throw new NotImplementedException();
		}

		public Car UpdateCar(Car UpdatedCar)
		{
			throw new NotImplementedException();
		}
	}
}
