﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces.Facade;

namespace CarAssistant.Classes.Facade
{
	public class UserManager : IUserManager
	{
		public void CreateNewUser()
		{
			throw new NotImplementedException();
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