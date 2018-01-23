using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces.Facade;
using System.Xml.Serialization;
using System.IO;
using CarAssistant;

namespace CarAssistant.Classes.Facade
{
	public class DataLoader : IDataLoader
	{
		public CarAssistant.Car LoadCarFromXml(string brand, string model, User owner, string path)
		{
			using (var file = new FileStream(path, FileMode.Open))
			{
				var load = new XmlSerializer(typeof(CarAssistant.Car));
				return (CarAssistant.Car)load.Deserialize(file);
			}
		}

		public List<CarAssistant.Car> LoadCarsListFromXml(string path)
		{
			using (var file = new FileStream(path, FileMode.Open))
			{
			    var load = new XmlSerializer(typeof(List<CarAssistant.Car>));
			    return (List<CarAssistant.Car>)load.Deserialize(file);
			}
		}

		public User LoadUserFromXml(string path)
		{
			using (var file = new FileStream(path, FileMode.Open))
			{
				var load = new XmlSerializer(typeof(CarAssistant.User));
				return (User)load.Deserialize(file);
			}

		}
	}
}
