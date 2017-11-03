using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Classes.User;
using CarAssistant.Interfaces;

namespace CarAssistant
{
	public class Car : ICar
	{
		//Fields
		private Brand Brand;
		private Model Model;
		private Engine Engine;
		private int ProductionYear;
		private User Owner;

		//Constructors
		public Car()
		{

		}

		//Methods
		public int CalculateAge()
		{
			throw new NotImplementedException();
		}

		public string WriteCarShortDescription()
		{
			throw new NotImplementedException();
		}

		public string WriteOwner()
		{
			throw new NotImplementedException();
		}
	}
}
