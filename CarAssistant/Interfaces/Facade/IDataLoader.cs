﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Interfaces.Facade
{
	public interface IDataLoader
	{
		List<Car> LoadCarsListFromXml(string Path);

		Car LoadCarFromXml(Brand Brand, Model Model, User Owner, string Path);

		User LoadUserFromXml(string Path);
	}
}
