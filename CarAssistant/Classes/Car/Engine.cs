using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarAssistant.Classes.Car;

namespace CarAssistant
{[Serializable]
	public class Engine
	{
        //Fields
        public int Capacity { get; set; }
        public int Horsepower { get; set; }
        public int PowerInKw { get; set; }
        public string TypeOfEngine { get; set; }

        // Constructor
        public Engine(int capacity, int horsepower, string inTypeOfEngine)
        {
            MenageEngine(inTypeOfEngine, capacity, horsepower);
        }
        public Engine()
        {

        }

        // Methods

        // HorsepowerTokW - Converts Power of the engine from Horsepower to kiloWatts
        private int HorsepowerTokW (int horsepower) 
        {
            double converter = 0.73549875;
            double kW = (horsepower * converter);
            Math.Round(kW, MidpointRounding.ToEven);
            int output = Convert.ToInt32(kW);
            return output;  
        }
        
        // Sets Capacity of the object
        private void SetCapacity(int inputCapacity)
        {
            Capacity = inputCapacity;
        }
        // Sets Horsepower of the object
        private void SetHorsepower (int inputHorsepower)
        {
            Horsepower = inputHorsepower;
        }
        // Sets PowerInkW of the object
        private void SetPowerInkW (int inputHorsepower)
        {
            PowerInKw = HorsepowerTokW(inputHorsepower);
        }
        
        //Checks what type of engine there is to create and creates one. In case of mistake in string TypeOfEngine
        // shows window.x
        private void MenageEngine(string inTypeOfEngine, int inCapacity, int inHorsepower)
        {
            if (inTypeOfEngine == "Petrol")
            {
                Capacity = inCapacity;
                Horsepower = inHorsepower;
                TypeOfEngine = inTypeOfEngine;
                PowerInKw = HorsepowerTokW(inHorsepower);


            }
            else if (inTypeOfEngine == "Diesel")
            {
                Capacity = inCapacity;
                Horsepower = inHorsepower;
                TypeOfEngine = inTypeOfEngine;
                PowerInKw = HorsepowerTokW(inHorsepower);
            }
            else if (inTypeOfEngine == "Petrol + LPG")
            {
                Capacity = inCapacity;
                Horsepower = inHorsepower;
                TypeOfEngine = inTypeOfEngine;
                PowerInKw = HorsepowerTokW(inHorsepower);
            }
            
            else
            {
                MessageBox.Show("Unkown type of engine. Resend data", "Alert!", MessageBoxButtons.OK);
            }

        }
        
         
    }
}
