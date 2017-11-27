using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarAssistant.Classes.Car;

namespace CarAssistant
{
	public class Engine
	{
        //Fields
        int Capacity;
        int Horsepower;
        int PowerInKW;
        string TypeOfEngine;
        
        // Constructor
        public Engine(int Capacity, int Horsepower, string InTypeOfEngine)
        {
            MenageEngine(InTypeOfEngine, Capacity, Horsepower);
        }
        public Engine()
        {

        }

        // Methods

        // HorsepowerTokW - Converts Power of the engine from Horsepower to kiloWatts
        private int HorsepowerTokW (int Horsepower) 
        {
            double Converter = 0.73549875;
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
        
        //Checks what type of engine there is to create and creates one. In case of mistake in string TypeOfEngine
        // shows window.x
        private void MenageEngine(string InTypeOfEngine, int InCapacity, int InHorsepower)
        {
            if (InTypeOfEngine == "Petrol")
            {
                Capacity = InCapacity;
                Horsepower = InHorsepower;
                TypeOfEngine = InTypeOfEngine;
                PowerInKW = HorsepowerTokW(InHorsepower);


            }
            else if (InTypeOfEngine == "Diesel")
            {
                Capacity = InCapacity;
                Horsepower = InHorsepower;
                TypeOfEngine = InTypeOfEngine;
                PowerInKW = HorsepowerTokW(InHorsepower);
            }
            else if (InTypeOfEngine == "Petrol + LPG")
            {
                Capacity = InCapacity;
                Horsepower = InHorsepower;
                TypeOfEngine = InTypeOfEngine;
                PowerInKW = HorsepowerTokW(InHorsepower);
            }
            
            else
            {
                MessageBox.Show("Unkown type of engine. Resend data", "Alert!", MessageBoxButtons.OK);
            }

        }
        
         
    }
}
