using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;
using CarAssistant.Classes;
using System.Windows.Forms;
using CarAssistant.Classes.Car;

namespace CarAssistant
{
	public class Car : ICar
	{
        //Fields
        private Engine Engine;
        private Model Model;
        private Brand Brand;
        private DateTime ProductionDate;
        private DateTime PurchaseDate;
        private User Owner;
        private double CounterState;
        private string LicensePlateNo;
        private string Vin;
        private int Index;
        //Constructors
        public Car(Brand InputBrand, Model InputModel, Engine InputEngine, DateTime InputProductionYear, 
            User InputOwner, DateTime InputPurchaseDate, double InputCounterState, string InputVin,
            string InputLicensePlateNumber)
        {
            Brand = InputBrand;
            Model = InputModel;
            ProductionDate = InputProductionYear;
            Owner = InputOwner;
            CounterState = InputCounterState;
            PurchaseDate = InputPurchaseDate;
            Engine = InputEngine;
            Vin = InputVin;
            SetIndex();
            LicensePlateNo = InputLicensePlateNumber;
        }


        public Car()
		{

		}

        //Methods
        
        /// <summary>
        /// Sets object parameter Brand
        /// </summary>
        public void SetBrand (Brand InBrand) 
        {
            Brand = InBrand;
        }
        
        /// <summary>
        /// Sets object's parameter Model
        /// </summary>
        public void SetModel(Model InModel) 
        {
            Model = InModel;
        }
        
        ///<summary>
        /// Sets object's parameter Engine
        /// </summary>
        public void SetEngine(Engine InEngine)
        {
            Engine = InEngine;
        }
        
        /// <summary>
        /// Sets object's parameter Production Date
        /// </summary>
        public void SetProductionDate(DateTime InDate) 
        {
            ProductionDate = InDate;
        }
        
        /// <summary>
        /// Sets object's parameter Owner
        /// </summary>
        public void SetOwner (User TheOneWhoOwns) 
        {
            Owner = TheOneWhoOwns;
        }
        
        /// <summary>
        /// Sets objcet's parameter CounterState
        /// </summary>
        public void SetCounterState(double InCounterState)
        {
            CounterState = InCounterState;
        }
        
        /// <summary>
        /// Sets object's patameter Purchase Date
        /// </summary>
        public void SetPurchaseDate(DateTime InPurchaseDate) 
        {
            PurchaseDate = InPurchaseDate;
        }
        /// <summary>
        /// Sets object's parameter Vin
        /// </summary>
        public void SetVin (string InputVin)
        {
            Vin = InputVin;
        }

        /// <summary>
        /// Sets object's parameter Vin
        /// </summary>
        public void SetIndex()
        {
            Index = Owner.userCars.Count + 1;
        }
        /// <summary>
        /// Sets object's parameter License Plate Number
        /// </summary>
        public void SetLicensePlatesNo(string LicPlaNo)
        {
            LicensePlateNo = LicPlaNo;
        }
        /// <summary>
        /// Returns object's parameter Brand
        /// </summary>
        public Brand GetBrand() 
        {
            return Brand;
        }
        
        /// <summary>
        ///Returns object's parameter Model
        /// </summary>
        public Model GetModel() 
        {
            return Model;
        }
        ///<summary>
        ///Returns object's parameter (object)Engine
        /// </summary>

        public Engine GetEngine()
        {
            return Engine;
        }

        /// <summary>
        ///Returns object's parameter Production Date
        /// </summary>
        public DateTime GetProductionDate() 
        {
            return ProductionDate;
        }
        
        /// <summary>
        ///Returns object's parameter Owner
        /// </summary>
        public User GetOwner() 
        {
            return Owner;
        }
        
        /// <summary>
        /// Returns object's parameter CounterState
        /// </summary>
        public double GetCounterState() 
        {
            return CounterState;
        }              
        
        /// <summary>
        /// Returns object's Purchase Date
        /// </summary>
        public DateTime GetPurchaseDate() 
        {
            return PurchaseDate;
        }
        /// <summary>
        /// Returns object's parameter Vin
        /// </summary>
        public string GetVin()
        {
            return Vin;
        }
        /// <summary>
        /// Find Car's Id in user list;
        /// </summary>
        public int GetIndex()
        {
            return Index;
        }
        /// <summary>
        ///Returns object's parameter License Plate Number
        /// </summary>        
        public string GetLicensePlateNo()
        {
            return LicensePlateNo;
        }
        /// <summary>
        /// Returns object's age in years
        /// </summary>
        public int CalculateAge() 
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
    

        /// <summary>
        /// Returns object's short description in string
        /// </summary>
        public string WriteCarShortDescription() 
		{
			string Output = string.Format("{0},{1},Year: {2}", GetBrand().ToString(), GetModel().ToString(), GetProductionDate().Year.ToString());
            return Output;
		}
        
        /// <summary>
        /// Returns inforamtion about object's owner
        /// </summary>
        public string WriteOwner() 
		{
            
            string Output = string.Format("{0}, owner since {1}", Owner.GetName(),GetPurchaseDate().Year.ToString() );
            return Output;
		}

        
	}
}
