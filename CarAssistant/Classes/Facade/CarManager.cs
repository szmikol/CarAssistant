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
		public void CreateNewCar(User WhichUser, Car NewCar)
		{
			throw new NotImplementedException();
		}

		public void DeleteCar(User WhichUser, Car CarToDelete)
		{
            CarToDelete.SetCarToNull();
            WhichUser.userCars.Remove(CarToDelete);            
		}

		public void DeleteCarByVin(User WhichUser, string Vin)
		{
            foreach(Car c in WhichUser.userCars)
            {
                if(c.GetVin() == Vin)
                {
                    c.SetCarToNull();
                    WhichUser.userCars.Remove(c);
                }
            }
            foreach (Car c in WhichUser.userCars)
            {
                if (c.GetVin() != Vin)
                {
                    MessageBox.Show("Something went wrong", "Unable to delete", MessageBoxButtons.OK);
                }
            }



        }

		public void DeleteCarByModel(User WhichUser, string Brand, string CarModel)
		{
			throw new NotImplementedException();
		}

		public Car FindCarById(User WhichUser, int Id)
		{
            foreach (Car c in WhichUser.userCars)
            {
                if (c.Index == Id)
                {
                    return c;
                }
            }
            MessageBox.Show("Car with this index does not exist in the system","Error!", MessageBoxButtons.OK);
            return null;
        }

		public List<Car> FindCardByModel(User WhichUser, string CarModel)
		{
            List<Car> ExportList = new List<Car>();
            foreach(Car c in WhichUser.userCars)
            {
                if(c.Model == CarModel)
                {
                    ExportList.Add(c);
                }
            }
            return ExportList;
		}

		public List<Car> FindCarsByBrand(User WhichUser, string CarBrand)
		{
            List<Car> ExportList = new List<Car>();
            foreach (Car c in WhichUser.userCars)
            {
                if (c.Brand == CarBrand)
                {
                    ExportList.Add(c);
                }
            }
            return ExportList;
        }

		public Dictionary<string, string> RetrieveAllCarsOfSpecificBrand(User WhichUser, string CarBrand)
		{
			throw new NotImplementedException();
		}

		public Car UpdateCar(User WhichUser, Car CarToUpdate, Car UpdatedCar)
		{
            CarToUpdate.ChangeCarsParameters(UpdatedCar);
            return CarToUpdate;
		}
	}
}
