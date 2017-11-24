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
		public void SaveCarsListToXml(List<CarAssistant.Car> Cars, string Path)
		{
            var serial = new XmlSerializer(typeof(List<CarAssistant.Car>));
            FileStream file = new FileStream(Path, FileMode.Create);
            serial.Serialize(file, Cars);
        }

		public void SaveCarToXml(CarAssistant.Car Car, string Path)
		{
            var serial = new XmlSerializer(typeof(CarAssistant.Car));
            FileStream file = new FileStream(Path, FileMode.Create);
            serial.Serialize(file, Car);
        }

		public void SaveUserToXml(User User, string Path)
		{
            var serial = new XmlSerializer(typeof(User));
            FileStream file = new FileStream(Path, FileMode.Create);
            serial.Serialize(file, User);
		}
	}
}
