using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Interfaces
{
	public interface IUser
	{
		//Method returns all cars of the user
		List<Car> retrieveCars();

		//Method to add new user car
		void AddNewCar(Car NewCar);

		//Method search and returns specific user car
		List<Car> FindCar(string Brand, string Model, int ProductionYear);

		//Method removes specific user car
		void RemoveCar(String vin);

		//Method to display a user representation as text
		//E.g. "Wiktor Tulej"
		string WriteUserShortDescription();
	}
}
