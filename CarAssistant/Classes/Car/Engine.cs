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
        string TypeOfEngine; // shows type of the engine f.e. Straight 6 or V6 or W12
        
        // Constructor
        public Engine(int Capacity, int Horsepower, string TypeOfEngine)
        {
            SetCapacity(Capacity);
            SetHorsepower(Horsepower);
            HorsepowerTokW(Horsepower);

        }
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

        /*private void MenageEngine(string TypeofEngine)
        {
        if(CheckTypeOfEngine(TypeOfEngine) == "P")
            {
                PetrolEngine TempPetrolEngine = new PetrolEngine(Capacity, Horsepower, TypeOfEngine);
                Engine = TempPetrolEngine;

            }
            else if (CheckTypeOfEngine(TypeOfEngine) == "F")
            {
                Engine TempDieselEngine = new Engine(Capacity, Horsepower, TypeOfEngine);
                Engine = TempDieselEngine;
            }
            else
            {
                MessageBox.Show("Unkown type of engine", "Alert!", MessageBoxButtons.OK);
            }

        }*/
         
        // Checks what is the type of the engine.
        private string CheckTypeOfEngine (string TypeOfEngine)
        {
            string ToComparision = TypeOfEngine;

            if (ToComparision == "Petrol")
            {
                return "P";
            }
            else if (ToComparision == "Diesel")
            {
                return "F";
            }
            return null;
        }   
         
    }
}
