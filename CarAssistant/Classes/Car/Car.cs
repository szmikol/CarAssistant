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
        private void SetModel(Model InModel) // Sets object parameter Model
        {
            Model = InModel;
        }
        private void SetProductionDate(DateTime InDate) // Sets object parameter Production Date
        {
            ProductionDate = InDate;
        }
        private void SetOwner (User TheOneWhoOwns) // Sets object parameter Owner
        {
            Owner = TheOneWhoOwns;
        }

        public int CalculateAge()
		{
			throw new NotImplementedException();
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
