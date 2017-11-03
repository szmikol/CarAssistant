using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant.Interfaces
{
	public interface ICar
	{
		//Method to display a short Car representation as text
		//E.g. "Toyota Corolla, 2003"
		string WriteCarShortDescription();

		//Method returns age of the car
		int CalculateAge();

		//Method to display a car owner representation as text
		//E.g. "Oskar Jańta since 2014"
		string WriteOwner();
	}
}
