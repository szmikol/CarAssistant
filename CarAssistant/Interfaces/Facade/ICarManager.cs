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
		void CreateNewCar(User wichUser, Car newCar);

		//Method removes specific car, base on its VIN number
		void DeleteCarByVin(User whichUser, string vin);

		//Method removes specific car, base on its Brand and Model
		void DeleteCarByModel(User whichUser, string brand, string carModel);

		//Method removes specific car
		void DeleteCar(User whichUser, Car carToDelete);

		//Method update and returns updated Car
		Car UpdateCar(User whichUser, Car carToUpdate, Car updatedCar);

		//Method search and returns specific Car by its ID number
		Car FindCarById(User whichUser, int id);

		//Method search and returns all Cars from system storage, base on its Brand
		List<Car> FindCarsByBrand(User whichUser, string carBrand);

		//Method search and returns all Cars from system storage, base on its Model
		List<Car> FindCardByModel(User whichUser, string carModel);

		//Method returns all Cars of specific Brand
		//E.g. Fiat Uno, Fiat Panda, Fiat Sedici etc.
		Dictionary<string, string> RetrieveAllCarsOfSpecificBrand(User whichUser, string carBrand);
	}
}
