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
	public class DataSaver : IDataSaver
	{
		public void SaveCarsListToXml(List<CarAssistant.Car> cars, string path)
		{
            var serial = new XmlSerializer(typeof(List<CarAssistant.Car>));
            FileStream file = new FileStream(path, FileMode.Create);
            serial.Serialize(file, cars);
        }

		public void SaveCarToXml(CarAssistant.Car car, string path)
		{
            var serial = new XmlSerializer(typeof(CarAssistant.Car));
            FileStream file = new FileStream(path, FileMode.Create);
            serial.Serialize(file, car);
        }

		public void SaveUserToXml(User user, string path)
		{
            var serial = new XmlSerializer(typeof(User));
            FileStream file = new FileStream(path, FileMode.Create);
            serial.Serialize(file, user);
		}
	}
}
