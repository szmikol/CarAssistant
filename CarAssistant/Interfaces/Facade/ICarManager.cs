using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant;

namespace CarAssistant.Interfaces
{
	public interface ICarManager
	{
		void CreateNewCar(Car NewCar);

		void DeleteCarById(int Id);

		void DeleteCarByModel(Model CarModel);

		void UpdateCar(Car UpdatedCar);

		Car FindCarById(int Id);

		List<Car> FindCarsByBrand(Brand CarBrand);

		List<Car> FindCardByModel(Model CarModel);

		Dictionary<Brand, Model> RetrieveAllModelsOfSpecificBrand(Brand CarBrand);
	}
}
