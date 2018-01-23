using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Interfaces.Facade
{
	public interface IDataLoader
	{
		List<Car> LoadCarsListFromXml(string path);

		Car LoadCarFromXml(string brand, string model, User owner, string path);

		User LoadUserFromXml(string path);
	}
}
