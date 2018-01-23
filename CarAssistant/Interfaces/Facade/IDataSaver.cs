using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Interfaces.Facade
{
	public interface IDataSaver
	{
		void SaveCarsListToXml(List<Car> cars, string path);

		void SaveCarToXml(Car car, string path);

		void SaveUserToXml(User user, string path);
	}
}
