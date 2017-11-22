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
            WhichUser.userCars.Remove(CarToDelete);            
		}

		public void DeleteCarById(User WhichUser, int Id)
		{
            foreach(Car c in WhichUser.userCars)
            {
                if(c.GetIndex() == Id)
                {
                    WhichUser.userCars.Remove(c);
                }
            }            
		}

		public void DeleteCarByModel(User WhichUser, Brand Brand, Model CarModel)
		{
			throw new NotImplementedException();
		}

		public Car FindCarById(User WhichUser, int Id)
		{
            foreach (Car c in WhichUser.userCars)
            {
                if (c.GetIndex() == Id)
                {
                    return c;
                }
            }
            MessageBox.Show("Car with this index does not exist in the system","Error!", MessageBoxButtons.OK);
            return null;
        }

		public List<Car> FindCardByModel(User WhichUser, Model CarModel)
		{
			throw new NotImplementedException();
		}

		public List<Car> FindCarsByBrand(User WhichUser, Brand CarBrand)
		{
			throw new NotImplementedException();
		}

		public Dictionary<Brand, Model> RetrieveAllCarsOfSpecificBrand(User WhichUser, Brand CarBrand)
		{
			throw new NotImplementedException();
		}

		public Car UpdateCar(User WhichUser, Car UpdatedCar)
		{
			throw new NotImplementedException();
		}
	}
}
