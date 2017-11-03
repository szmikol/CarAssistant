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
		//Method allow to create a new car and add it to the system storage
		void CreateNewCar(Car NewCar);

		//Method removes specific car, base on its ID number
		void DeleteCarById(int Id);

		//Method removes specific car, base on its Brand and Model
		void DeleteCarByModel(Brand Brand, Model CarModel);

		//Method removes specific car
		void DeleteCar(Car CarToDelete);

		//Method update and returns updated Car
		Car UpdateCar(Car UpdatedCar);

		//Method search and returns specific Car by its ID number
		Car FindCarById(int Id);

		//Method search and returns all Cars from system storage, base on its Brand
		List<Car> FindCarsByBrand(Brand CarBrand);

		//Method search and returns all Cars from system storage, base on its Model
		List<Car> FindCardByModel(Model CarModel);

		//Method returns all Cars of specific Brand
		//E.g. Fiat Uno, Fiat Panda, Fiat Sedici etc.
		Dictionary<Brand, Model> RetrieveAllCarsOfSpecificBrand(Brand CarBrand);
	}
}
