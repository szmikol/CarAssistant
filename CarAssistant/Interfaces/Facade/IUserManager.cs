using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Interfaces.Facade
{
	public interface IUserManager
	{
		//Method allows to create a new user and add it to the system storage
		void CreateNewUser();

		//Method removes specific user
		void RemoveUser(User UserToRemove);

		//Method allows to update existing user
		void UpdateUser(User UpdatedUser);

		//Method allows to search specific user, base on its surname
		User FindUserBySurname(string Surname);

		//Method allows to search specific user, base on its ID number
		User FindUserById(int Id);

		//Method returns all users cars
		List<Car> RetrieveUsersCars();

		//Method allows to search specific users car, base on its Model (then Brand is unecessary) and Production Year
		Car RetrieveUsersSpecificCar(string Model, int ProductionYear);
	}
}
