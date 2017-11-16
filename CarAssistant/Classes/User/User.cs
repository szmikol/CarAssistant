﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;
using System.Windows.Forms;

namespace CarAssistant
{
	public class User : IUser
	{
        /// <summary>
        /// Full name of the user: "Name Surname".
        /// </summary>
        public string name;
        /// <summary>
        /// User's birth date: DD-MM-YYYY.
        /// </summary>
        public DateTime birthDate;
        /// <summary>
        /// Number of user's identity document.
        /// </summary>
        public int idNumber;
        /// <summary>
        /// Number of user's driving licence.
        /// </summary>
        public int licenceNumber;
        /// <summary>
        /// Date of issue of the driver's licence
        /// </summary>
        public DateTime licenceDate;
        /// <summary>
        /// Legal residence address in format: "street,post code, city".
        /// </summary>
        public string residenceAddress;
        /// <summary>
        /// List of cars owned by user.
        /// </summary>
        public List<Car> userCars;
        private string userDescription; // Used in method WriteUserShortDescription(): name,age,number of owned cars
        private int userAge; // Used in method WriteUserShortDescription(): calculates user's age in years
        private int userOwnedCars; // Used in method WriteUserShortDescription():counts cars owned by user.

        public User(string name, DateTime birthdate, int idNumber, int licenceNumber, string street, int postCode, string city)
        {
            userCars = new List<Car>();
            SetName(name);
            SetBirthdate(birthdate);
            SetIdNumber(idNumber);
            SetLicenceNumber(licenceNumber);
            SetResidenceAddress(street, postCode, city);
        }
        public User()
        {
            userCars = new List<Car>();
        }

        /// <summary>
        /// Method adds new car to the user's car list "userCars".
        /// </summary>
        /// <param name="NewCar"></param>
		public void AddNewCar(Car NewCar)
		{
            userCars.Add(NewCar);
		}

        /// <summary>
        /// Finds car in user's car list by Brand, Model and ProductionYear.
        /// </summary>
        /// <param name="Brand"></param>
        /// <param name="Model"></param>
        /// <param name="ProductionYear"></param>
        /// <returns></returns>
		public Car FindCar(Brand Brand, Model Model, int ProductionYear)
		{
            int index = 0;
            for (int i = 0; i < userCars.Count(); i++)
            {
                if (Brand == userCars[i].GetBrand())
                {
                    if (Model == userCars[i].GetModel())
                    {
                        int Year = userCars[i].GetProductionDate().Year;
                        if (ProductionYear == Year)
                        {
                            index = i;
                            break;
                        }
                    }
                }
            }
            return userCars[index];
        }

        /// <summary>
        /// Removes car from user's car list by Brand, Model, ProductionYear.
        /// </summary>
        /// <param name="Brand"></param>
        /// <param name="Model"></param>
        /// <param name="ProductionYear"></param>
		public void RemoveCar(Brand Brand, Model Model, int ProductionYear)
		{
            bool delete = false;
            int brandIndex = 0;
            int modelIndex = 0;
            int yearIndex = 0;

            brandIndex = RemoveCarBrand(Brand);
            modelIndex = RemoveCarModel(Model, brandIndex);
            yearIndex = RemoveCarYear(ProductionYear, modelIndex);
            delete = DeleteCar(brandIndex, modelIndex, yearIndex);
            ShowDeleteMessage(delete);
		}
        private bool DeleteCar(int brandIndex, int modelIndex, int yearIndex)
        {
            bool delete = false;
            if(brandIndex == modelIndex && modelIndex == yearIndex)
            {
                userCars.RemoveAt(brandIndex);
                delete = true;
            }
            else
            {
                delete = false;
            }
            return delete;
        }
        private int RemoveCarBrand(Brand brand)
        {
            int brandIndex = -1;
            for (int i = 0; i < userCars.Count(); i++)
            {
                if(brand == userCars[i].GetBrand())
                {
                    brandIndex = i;
                }
            }
            return brandIndex;
        }
        private int RemoveCarModel(Model model, int index)
        {
            int modelIndex = -2;
            if(userCars[index].GetModel() == model)
            {
                modelIndex = index;
            }
            return modelIndex;
        }
        private int RemoveCarYear(int ProductionYear, int index)
        {
            int yearIndex = -3;
            if(userCars[index].GetProductionDate().Year == ProductionYear)
            {
                yearIndex = index;
            }
            return yearIndex;
        }
        private void ShowDeleteMessage(bool delete)
        {
            if (!delete)
            {
                MessageBox.Show("Car with entered parameters was not found.", "Deletion failed.", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Car deleted!", "Deletion successful", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Returns user's car list "userCars".
        /// </summary>
        /// <returns></returns>
		public List<Car> retrieveCars()
		{
            return userCars;
		}

        /// <summary>
        /// Writes short description of a user. Name, age, number of owned cars.
        /// </summary>
        /// <returns></returns>
		public string WriteUserShortDescription()
		{
            userAge = GetUserAge();
            userOwnedCars = userCars.Count();
            userDescription = string.Format("{0},{1},{2}", name, userAge, userOwnedCars);
            return userDescription;
		}

        /// <summary>
        /// Returns age of user.
        /// </summary>
        /// <returns></returns>
        public int GetUserAge()
        {
            DateTime dateToday = DateTime.Today;
            userAge = dateToday.Year - birthDate.Year;
            return userAge;
        }
        /// <summary>
        /// Sets user "Name surname".
        /// </summary>
        /// <param name="nameInput"></param>
        private void SetName(string nameInput)
        {
            name = nameInput;
        }
        /// <summary>
        /// Returns "Name surname" of user.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Sets user's birthdate.
        /// </summary>
        /// <param name="BirthInput"></param>
        private void SetBirthdate(DateTime BirthInput)
        {
            birthDate = BirthInput;
        }
        /// <summary>
        /// Returns user's birthdate.
        /// </summary>
        /// <returns></returns>
        public DateTime GetBirthdate()
        {
            return birthDate;
        }
        /// <summary>
        /// Sets user's ID number.
        /// </summary>
        /// <param name="idInput"></param>
        private void SetIdNumber(int idInput)
        {
            idNumber = idInput;
        }
        /// <summary>
        /// Returns user's ID number.
        /// </summary>
        /// <returns></returns>
        public int GetIdNumber()
        {
            return idNumber;
        }
        /// <summary>
        /// Sets licence
        /// </summary>
        /// <param name="plateInput"></param>
        private void SetLicenceNumber(int licenceNrInput)
        {
            licenceNumber = licenceNrInput;
        }
        /// <summary>
        /// Returns user's licence number.
        /// </summary>
        /// <returns></returns>
        public int GetLicenceNumber()
        {
            return licenceNumber;
        }
        /// <summary>
        /// Sets date of issue of the driver's licence.
        /// </summary>
        /// <param name="dateInput"></param>
        private void SetLicenceDate(DateTime dateInput)
        {
            licenceDate = dateInput;
        }
        /// <summary>
        /// Returns date of issue of the driver's licence.
        /// </summary>
        /// <returns></returns>
        public DateTime GetLicenceDate()
        {
            return licenceDate;
        }

        /// <summary>
        /// Sets user's residence address.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="postCode"></param>
        /// <param name="city"></param>
        private void SetResidenceAddress(string street, int postCode, string city)
        {
            residenceAddress = string.Format("{0},{1},{2}", street, postCode, city);
        }
        /// <summary>
        /// Returns user's residence address in format "street,post code,city".
        /// </summary>
        /// <returns></returns>
        public string GetResidenceAddress()
        {
            return residenceAddress;
        }

        /// <summary>
        /// Edits users existing data, if bool == true, then enter new data to edit.
        /// </summary>
        /// <param name="nameB"></param>
        /// <param name="birthB"></param>
        /// <param name="idNumberB"></param>
        /// <param name="licenceNumberB"></param>
        /// <param name="addressB"></param>
        /// <param name="name"></param>
        /// <param name="birthdate"></param>
        /// <param name="idNumber"></param>
        /// <param name="licenceNumber"></param>
        /// <param name="street"></param>
        /// <param name="postCode"></param>
        /// <param name="city"></param>
        public void EditUserSpecifiedData(bool nameB, bool birthB, bool idNumberB, bool licenceNumberB, bool addressB, 
            string name, DateTime birthdate, int idNumber, int licenceNumber, string street, int postCode, string city)
        {
            EditName(nameB, name);
            EditBirthDate(birthB, birthdate);
            EditIdNumber(idNumberB, idNumber);
            EditLicenceNumber(licenceNumberB, licenceNumber);
            EditAddress(addressB, street, postCode, city);
        }
        private void EditName(bool nameB, string name)
        {
            if(nameB)
            {
                SetName(name);
                MessageBox.Show("User's name edit successful!", "Success!", MessageBoxButtons.OK);
            }
        }
        private void EditBirthDate(bool birthB, DateTime birthDate)
        {
            if (birthB)
            {
                SetBirthdate(birthDate);
                MessageBox.Show("User's birth date edit successful!", "Success!", MessageBoxButtons.OK);
            }
        }
        private void EditIdNumber(bool idBool, int idNumber)
        {
            if (idBool)
            {
                SetIdNumber(idNumber);
                MessageBox.Show("User's ID number edit successful!", "Success!", MessageBoxButtons.OK);
            }
        }
        private void EditLicenceNumber(bool licenceB, int licenceNumber)
        {
            if (licenceB)
            {
                SetLicenceNumber(licenceNumber);
                MessageBox.Show("Driver's licence number edit successful!", "Success!", MessageBoxButtons.OK);
            }
        }
        private void EditAddress(bool address, string street, int postCode, string city)
        {
            if (address)
            {
                SetResidenceAddress(street, postCode, city);
                MessageBox.Show("User's residence address edit successful!", "Success!", MessageBoxButtons.OK);
            }
        }
	}
}
