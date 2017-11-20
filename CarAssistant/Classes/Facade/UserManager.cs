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
        public User driver;
        private List<User> userGlobalList = new List<User>();
		public void CreateNewUser()
		{
            FormCreateUser formUser = new FormCreateUser();
            driver = formUser.CreateUser();
            //formUser.ReadTextboxes(out string name, out DateTime birthDate, out int idNumber, out int licenceNumber, out licenceRelease, out street, out postCode, out city);
            //driver = new User(name,birthDate,idNumber,licenceNumber,licenceRelease,street,postCode,city);
		}

		public User FindUserById(int Id)
		{
			throw new NotImplementedException();
		}

		public User FindUserBySurname(string Surname)
		{
			throw new NotImplementedException();
		}

		public void RemoveUser(User UserToRemove)
		{
			throw new NotImplementedException();
		}

		public List<CarAssistant.Car> RetrieveUsersCars()
		{
			throw new NotImplementedException();
		}

		public CarAssistant.Car RetrieveUsersSpecificCar(Model Model, int ProductionYear)
		{
			throw new NotImplementedException();
		}

		public void UpdateUser(User UpdatedUser)
		{
			throw new NotImplementedException();
		}
	}
}
