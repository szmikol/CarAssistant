using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;

namespace CarAssistant
{
	public class User : IUser
	{
		public void AddNewCar(Car NewCar)
		{
			throw new NotImplementedException();
		}

		public Car FindCar(Brand Brand, Model Model, int ProductionYear)
		{
			throw new NotImplementedException();
		}

		public void RemoveCar(Brand Brand, Model Model, int ProductionYear)
		{
			throw new NotImplementedException();
		}

		public List<Car> retrieveCars()
		{
			throw new NotImplementedException();
		}

		public string WriteUserShortDescription()
		{
			throw new NotImplementedException();
		}
	}
}
