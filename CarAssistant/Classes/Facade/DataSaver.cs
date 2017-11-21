using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces.Facade;
using System.Xml.Serialization;
using System.IO;

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
            var serial = new XmlSerializer(typeof(User));
            FileStream file = new FileStream(Path, FileMode.CreateNew);
            serial.Serialize(file, User);
		}
	}
}
