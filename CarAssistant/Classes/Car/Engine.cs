using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant
{
	public class Engine
	{
        //Fields
        int Capacity;
        int Horsepower;
        int PowerInKW;
        
        // Constructor
        public Engine()
        {

        }

        // Methods

        // HorsepowerTokW - Converts Power of the engine from Horsepower to kiloWatts
        private double HorsepowerTokW (int Horsepower) 
        {
            double Converter = 0.745699872;
            double kW = (Horsepower * Converter);
            return kW;
        }


	}
}
