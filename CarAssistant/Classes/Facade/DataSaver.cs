using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces.Facade;

namespace CarAssistant.Classes.Facade
{
	public class DataSaver : IDataSaver
	{
		public void SaveCarsListToXml(List<CarAssistant.Car> Cars, string Path)
		{
			throw new NotImplementedException();
		}

		public void SaveCarToXml(CarAssistant.Car Car, string Path)
		{
			throw new NotImplementedException();
		}

		public void SaveUserToXml(User User, string Path)
		{
			throw new NotImplementedException();
		}
	}
}
