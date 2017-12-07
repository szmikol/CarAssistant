using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;
using CarAssistant.Classes;
using System.Windows.Forms;
using CarAssistant.Classes.Car;
using System.Globalization;

namespace CarAssistant
{
    public class Car : ICar
	{
        //Fields

        public Engine Engine;
        public List<object> expenses { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime PurchaseDate;
        public User Owner;
        public double CounterState;
        public string LicensePlateNo { get; set; }
        public string Vin;
        public int Index { get; set; }
        public string BodyType { get; set; }
        //Constructors
        public Car(string InputBrand, string InputModel, Engine InputEngine, DateTime InputProductionYear, 
            User InputOwner, DateTime InputPurchaseDate, double InputCounterState, string InputVin,
            string InputLicensePlateNumber, string InBodyType)
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
            BodyType = InBodyType;
            expenses = new List<object>();
        }


        public Car()
		{
            expenses = new List<object>();
        }

        //Methods
        
        
            
        /// <summary>
        /// Sets object parameter Brand
        /// </summary>
        //public void SetBrand (string InBrand) 
        //{
        //    Brand = InBrand;
        //}
        
        /// <summary>
        /// Sets object's parameter Model
        /// </summary>
        //public void SetModel(string InModel) 
        //{
        //    Model = InModel;
        //}
        
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
        //public void SetProductionDate(DateTime InDate) 
        //{
        //    ProductionDate = InDate;
        //}
        
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
        //public void SetLicensePlatesNo(string LicPlaNo)
        //{
        //    LicensePlateNo = LicPlaNo;
        //}
        /// <summary>
        /// Sets object's parameter Body Type
        /// </summary>
        //public void SetBodyType (string InputBodyType)
        //{
        //    BodyType = InputBodyType;
        //}
        /// <summary>
        /// Returns object's parameter Brand
        /// </summary>
        //public string GetBrand() 
        //{
        //    return Brand;
        //}
        
        /// <summary>
        ///Returns object's parameter Model
        /// </summary>
        //public string GetModel() 
        //{
        //    return Model;
        //}
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
        //public DateTime GetProductionDate() 
        //{
        //    return ProductionDate;
        //}
        
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
        //public int GetIndex()
        //{
        //    return Index;
        //}
        /// <summary>
        ///Returns object's parameter License Plate Number
        /// </summary>        
        //public string GetLicensePlateNo()
        //{
        //    return LicensePlateNo;
        //}
        /// <summary>
        ///Returns object's Body Tpe
        /// </summary>
        //public string GetBodyType()
        //{
        //    return BodyType;
        //}
        /// <summary>
        /// Returns object's age in years
        /// </summary>
        public int CalculateAge() 
		{
            DateTime Present = DateTime.Now;
            DateTime CarDate = ProductionDate;
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
			string Output = string.Format("{0},{1},Year: {2}", Brand, Model, ProductionDate.Year.ToString());
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

        /// <summary>
        /// Sets all parameters to null. Useful when object is deleted,
        /// when parameters are null Garbage Collector will take it sooner.
        /// </summary>
        public void SetCarToNull()
        {            
            Brand = "";            
            ProductionDate = DateTime.ParseExact("01-01-0001", "DD-MM-YYYY", CultureInfo.InvariantCulture);
            Owner = null;
            CounterState = 0;
            PurchaseDate = DateTime.ParseExact("01-01-0001", "DD-MM-YYYY", CultureInfo.InvariantCulture);
            Engine = null;
            Vin = null;
            Index = 0;
            LicensePlateNo = null;
        }
        /// <summary>
        /// Change all parameters of the car based on input Car data. Returns updated object
        /// </summary>
        public void ChangeCarsParameters(Car InputCar)
        {
            Brand = InputCar.Brand;
            Model = InputCar.Model;
            SetEngine(InputCar.GetEngine());
            LicensePlateNo = InputCar.LicensePlateNo;
            ProductionDate = InputCar.ProductionDate;
            SetPurchaseDate(InputCar.GetPurchaseDate());
            SetVin(InputCar.GetVin());
            SetCounterState(InputCar.GetCounterState());
        }

	}
}
