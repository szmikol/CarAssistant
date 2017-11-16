using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces.Facade;

namespace CarAssistant.Classes.Facade
{
	public class DataLoader : IDataLoader
	{
		public CarAssistant.Car LoadCarFromXml(Brand Brand, Model Model, User Owner, string Path)
		{
			throw new NotImplementedException();
		}

		public List<CarAssistant.Car> LoadCarsListFromXml(string Path)
		{
			throw new NotImplementedException();
		}

		public User LoadUserFromXml(string Path)
		{
			throw new NotImplementedException();
		}
	}
}
