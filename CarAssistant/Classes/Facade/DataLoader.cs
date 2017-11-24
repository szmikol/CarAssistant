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
		public CarAssistant.Car LoadCarFromXml(Brand Brand, Model Model, User Owner, string Path)
		{
            var file = new FileStream(Path, FileMode.Open);
            var load = new XmlSerializer(typeof(CarAssistant.Car));
            return (CarAssistant.Car)load.Deserialize(file);
        }

		public List<CarAssistant.Car> LoadCarsListFromXml(string Path)
		{
            var file = new FileStream(Path, FileMode.Open);
            var load = new XmlSerializer(typeof(List<CarAssistant.Car>));
            return (List<CarAssistant.Car>)load.Deserialize(file);
        }

		public User LoadUserFromXml(string Path)
		{
            var file = new FileStream(Path,FileMode.Open);
            var load = new XmlSerializer(typeof(User));
            return (User)load.Deserialize(file);

		}
	}
}
