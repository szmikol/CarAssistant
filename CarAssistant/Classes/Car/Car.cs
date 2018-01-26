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
using CarAssistant.Classes.Expenses;

namespace CarAssistant
{
    public class Car : ICar
    {
        //Fields
        public Engine Engine;
        public List<Expense> Expenses { get; set; }

        public string Model { get; set; }
        public string Brand { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        private User _owner;
        public double CounterState;
        public string LicensePlateNo { get; set; }
        public string Vin { get; set; }
        public int Index { get; set; }
        public string BodyType { get; set; }
        //Constructors
        public Car(string inputBrand, string inputModel, Engine inputEngine, DateTime inputProductionYear, 
            User inputOwner, DateTime inputPurchaseDate, double inputCounterState, string inputVin,
            string inputLicensePlateNumber, string inBodyType)
        {
            Brand = inputBrand;
            Model = inputModel;
            ProductionDate = inputProductionYear;
            _owner = inputOwner;
            CounterState = inputCounterState;
            PurchaseDate = inputPurchaseDate;
            Engine = inputEngine;
            Vin = inputVin;
            SetIndex();
            LicensePlateNo = inputLicensePlateNumber;
            BodyType = inBodyType;
        }


        public Car()
		{

        }

        public void AddExpense(Expense exp)
        {
            Expenses.Add(exp);
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
        public void SetEngine(Engine inEngine)
        {
            Engine = inEngine;
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
        public void SetOwner (User theOneWhoOwns) 
        {
            _owner = theOneWhoOwns;
        }
        
        /// <summary>
        /// Sets objcet's parameter CounterState
        /// </summary>
        public void SetCounterState(double inCounterState)
        {
            CounterState = inCounterState;
        }
        
        /// <summary>
        /// Sets object's patameter Purchase Date
        /// </summary>
        public void SetPurchaseDate(DateTime inPurchaseDate) 
        {
            PurchaseDate = inPurchaseDate;
        }
        /// <summary>
        /// Sets object's parameter Vin
        /// </summary>
        public void SetVin (string inputVin)
        {
            Vin = inputVin;
        }

        /// <summary>
        /// Sets object's parameter Vin
        /// </summary>
        public void SetIndex()
        {
            Index = _owner.UserCars.Count + 1;
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
            return _owner;
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
            DateTime present = DateTime.Now;
            DateTime carDate = ProductionDate;
            int age = present.Year - carDate.Year;
            if (present.Month < carDate.Month || (present.Month == carDate.Month && present.Day < carDate.Day))
            {
                age--;
            }
            return age;
        }
    

        /// <summary>
        /// Returns object's short description in string
        /// </summary>
        public string WriteCarShortDescription() 
		{
			string output = string.Format("{0},{1},Year: {2}", Brand, Model, ProductionDate.Year.ToString());
            return output;
		}
        
        /// <summary>
        /// Returns inforamtion about object's owner
        /// </summary>
        public string WriteOwner() 
		{
            
            string output = string.Format("{0}, owner since {1}", _owner.GetName(),GetPurchaseDate().Year.ToString() );
            return output;
		}

        /// <summary>
        /// Sets all parameters to null. Useful when object is deleted,
        /// when parameters are null Garbage Collector will take it sooner.
        /// </summary>
        public void SetCarToNull()
        {            
            Brand = "";            
            //ProductionDate = DateTime.ParseExact("01-01-0001", "DD-MM-YYYY", CultureInfo.InvariantCulture);
            _owner = null;
            CounterState = 0;
            //PurchaseDate = DateTime.ParseExact("01-01-0001", "DD-MM-YYYY", CultureInfo.InvariantCulture);
            Engine = null;
            Vin = null;
            Index = 0;
            LicensePlateNo = null;
        }
        /// <summary>
        /// Change all parameters of the car based on input Car data. Returns updated object
        /// </summary>
        public void ChangeCarsParameters(Car inputCar)
        {
            Brand = inputCar.Brand;
            Model = inputCar.Model;
            SetEngine(inputCar.GetEngine());
            LicensePlateNo = inputCar.LicensePlateNo;
            ProductionDate = inputCar.ProductionDate;
            SetPurchaseDate(inputCar.GetPurchaseDate());
            SetVin(inputCar.GetVin());
            SetCounterState(inputCar.GetCounterState());
        }

	}
}
