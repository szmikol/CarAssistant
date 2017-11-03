using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;

namespace CarAssistant.Classes.Facade
{
	public class CarManager : ICarManager
	{
		public void CreateNewCar(Car car)
		{
			throw new NotImplementedException();
		}

		public void DeleteCarById(int Id)
		{
			throw new NotImplementedException();
		}

		public void DeleteCarByModel(Model CarModel)
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

		public Dictionary<Brand, Model> RetrieveAllModelsOfSpecificBrand(Brand CarBrand)
		{
			throw new NotImplementedException();
		}

		public void UpdateCar(Car UpdatedCar)
		{
			throw new NotImplementedException();
		}
	}
}
