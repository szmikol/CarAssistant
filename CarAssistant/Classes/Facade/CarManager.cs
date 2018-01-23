using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Classes;
using CarAssistant.Interfaces;
using System.Windows.Forms;

namespace CarAssistant
{
	public class CarManager : ICarManager
	{
		public void CreateNewCar(User whichUser, Car newCar)
		{
			throw new NotImplementedException();
		}

		public void DeleteCar(User whichUser, Car carToDelete)
		{
            carToDelete.SetCarToNull();
            whichUser.UserCars.Remove(carToDelete);            
		}

		public void DeleteCarByVin(User whichUser, string vin)
		{
            foreach(Car c in whichUser.UserCars)
            {
                if(c.GetVin() == vin)
                {
                    c.SetCarToNull();
                    whichUser.UserCars.Remove(c);
                }
            }
            foreach (Car c in whichUser.UserCars)
            {
                if (c.GetVin() != vin)
                {
                    MessageBox.Show("Something went wrong", "Unable to delete", MessageBoxButtons.OK);
                }
            }



        }

		public void DeleteCarByModel(User whichUser, string brand, string carModel)
		{
			throw new NotImplementedException();
		}

		public Car FindCarById(User whichUser, int id)
		{
            foreach (Car c in whichUser.UserCars)
            {
                if (c.Index == id)
                {
                    return c;
                }
            }
            MessageBox.Show("Car with this index does not exist in the system","Error!", MessageBoxButtons.OK);
            return null;
        }

		public List<Car> FindCardByModel(User whichUser, string carModel)
		{
            List<Car> exportList = new List<Car>();
            foreach(Car c in whichUser.UserCars)
            {
                if(c.Model == carModel)
                {
                    exportList.Add(c);
                }
            }
            return exportList;
		}

		public List<Car> FindCarsByBrand(User whichUser, string carBrand)
		{
            List<Car> exportList = new List<Car>();
            foreach (Car c in whichUser.UserCars)
            {
                if (c.Brand == carBrand)
                {
                    exportList.Add(c);
                }
            }
            return exportList;
        }

		public Dictionary<string, string> RetrieveAllCarsOfSpecificBrand(User whichUser, string carBrand)
		{
			throw new NotImplementedException();
		}

		public Car UpdateCar(User whichUser, Car carToUpdate, Car updatedCar)
		{
            carToUpdate.ChangeCarsParameters(updatedCar);
            return carToUpdate;
		}
	}
}
