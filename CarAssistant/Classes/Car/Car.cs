using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;

namespace CarAssistant
{
	public class Car : ICar
	{
        //Fields
        Engine Engine;
        Model Model;
        Brand Brand;
        DateTime ProductionDate;
        User Owner;
        //Constructors
        public Car(Brand InputBrand, Model InputModel, DateTime ProductionDate, User Owner)
        {
            SetBrand(InputBrand);
            SetModel(InputModel);
            SetProductionDate(ProductionDate);
            SetOwner(Owner);
            
        }


        public Car()
		{

		}

		//Methods
        private void SetBrand (Brand InBrand) // Sets object parameter Brand
        {
            Brand = InBrand;
        }
        private void SetModel(Model InModel) // Sets object's parameter Model
        {
            Model = InModel;
        }
        private void SetProductionDate(DateTime InDate) // Sets object's parameter Production Date
        {
            ProductionDate = InDate;
        }
        private void SetOwner (User TheOneWhoOwns) // Sets object's parameter Owner
        {
            Owner = TheOneWhoOwns;
        }
        public Brand GetBrand() // Returns object's parameter Brand
        {
            return Brand;
        }
        public Model GetModel() //Returns object's parameter Model
        {
            return Model;
        }
        public DateTime GetProductionDate() //Returns object's parameter Production Date
        {
            return ProductionDate;
        }
        public User GetOwner() //Returns object's parameter Owner
        {
            return Owner;
        }

        public int CalculateAge() // Returns object's age in years
		{
            DateTime Present = DateTime.Now;
            DateTime CarDate = GetProductionDate();
            int Age = Present.Year - CarDate.Year;
            if (Present.Month < CarDate.Month || (Present.Month == CarDate.Month && Present.Day < CarDate.Day))
            {
                Age--;
            }
            return Age;
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
