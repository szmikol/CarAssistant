using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Interfaces.Facade
{
	public interface IDataSaver
	{
		void SaveCarsListToXml(List<Car> Cars, string Path);

		void SaveCarToXml(Car Car, string Path);

		void SaveUserToXml(User User, string Path);
	}
}
