using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces.Facade;

namespace CarAssistant.Classes.Facade
{
	public class UserManager : IUserManager
	{
        public User Driver;
        private List<User> _userGlobalList = new List<User>();
		public void CreateNewUser()
		{

		}

		public User FindUserById(int id)
		{
			throw new NotImplementedException();
		}

		public User FindUserBySurname(string surname)
		{
			throw new NotImplementedException();
		}

		public void RemoveUser(User userToRemove)
		{
			throw new NotImplementedException();
		}

		public List<CarAssistant.Car> RetrieveUsersCars()
		{
			throw new NotImplementedException();
		}

		public CarAssistant.Car RetrieveUsersSpecificCar(string model, int productionYear)
		{
			throw new NotImplementedException();
		}

		public void UpdateUser(User updatedUser)
		{
			throw new NotImplementedException();
		}
	}
}
