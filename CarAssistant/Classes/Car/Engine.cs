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
        private int HorsepowerTokW (int Horsepower) 
        {
            double Converter = 0.745699872;
            double kW = (Horsepower * Converter);
            Math.Round(kW, MidpointRounding.ToEven);
            int Output = Convert.ToInt32(kW);
            return Output;  
        }
        
        // Sets Capacity of the object
        private void SetCapacity(int InputCapacity)
        {
            Capacity = InputCapacity;
        }
        // Sets Horsepower of the object
        private void SetHorsepower (int InputHorsepower)
        {
            Horsepower = InputHorsepower;
        }
        // Sets PowerInkW of the object
        private void SetPowerInkW (int InputHorsepower)
        {
            PowerInKW = HorsepowerTokW(InputHorsepower);
        }
	}
}
