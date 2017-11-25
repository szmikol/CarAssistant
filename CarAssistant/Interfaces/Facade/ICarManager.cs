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
		void CreateNewCar(User WichUser, Car NewCar);

		//Method removes specific car, base on its VIN number
		void DeleteCarByVin(User WhichUser, string Vin);

		//Method removes specific car, base on its Brand and Model
		void DeleteCarByModel(User WhichUser, string Brand, string CarModel);

		//Method removes specific car
		void DeleteCar(User WhichUser, Car CarToDelete);

		//Method update and returns updated Car
		Car UpdateCar(User WhichUser, Car CarToUpdate, Car UpdatedCar);

		//Method search and returns specific Car by its ID number
		Car FindCarById(User WhichUser, int Id);

		//Method search and returns all Cars from system storage, base on its Brand
		List<Car> FindCarsByBrand(User WhichUser, string CarBrand);

		//Method search and returns all Cars from system storage, base on its Model
		List<Car> FindCardByModel(User WhichUser, string CarModel);

		//Method returns all Cars of specific Brand
		//E.g. Fiat Uno, Fiat Panda, Fiat Sedici etc.
		Dictionary<string, string> RetrieveAllCarsOfSpecificBrand(User WhichUser, string CarBrand);
	}
}
