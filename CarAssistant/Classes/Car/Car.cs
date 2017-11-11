﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;
using CarAssistant.Classes;
using System.Windows.Forms;

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
        double CounterState;
        
        //Constructors
        public Car(Brand InputBrand, Model InputModel, DateTime InputProductionDate, User InputOwner, double InputCounterState)
        {
            SetBrand(InputBrand);
            SetModel(InputModel);
            SetProductionDate(ProductionDate);
            SetOwner(Owner);
            SetCounterState(InputCounterState);
           

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

        private void SetCounterState(double InCounterState) // Sets objcet's parameter CounterState
        {
            CounterState = InCounterState;
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

        public double GetCounterState() // Returns object's parameter CounterState
        {
            return CounterState;
        }

        public Engine GetEngine() // Returns object's Engine object
        {
            return Engine;
        }

        public void AddEngineToTheCar(int Capacity, int Horsepower, string TypeOfEngine)
        {           
            Engine TempEngine = new Engine(Capacity, Horsepower, TypeOfEngine);
            Engine = TempEngine;
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
