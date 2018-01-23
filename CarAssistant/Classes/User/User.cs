using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAssistant.Interfaces;
using System.Windows.Forms;

namespace CarAssistant
{
    [Serializable]
    public class User : IUser
    {
        /// <summary>
        /// Full name of the user: "Name Surname".
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// User's birth date: DD-MM-YYYY.
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Number of user's identity document.
        /// </summary>
        public string IdNumber { get; set; }
        /// <summary>
        /// Number of user's driving licence.
        /// </summary>
        public string LicenceNumber { get; set; }
        /// <summary>
        /// Date of issue of the driver's licence
        /// </summary>
        public DateTime LicenceDate { get; set; }
        /// <summary>
        /// Legal residence address in format: "street,post code, city".
        /// </summary>
        public string ResidenceAddress { get; set; }
        /// <summary>
        /// List of cars owned by user.
        /// </summary>
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public List<Car> UserCars { get; set; }
        public string UserDescription { get; set; } // Used in method WriteUserShortDescription(): name,age,number of owned cars
        public int UserAge { get; set; } // Used in method WriteUserShortDescription(): calculates user's age in years
        public int UserOwnedCars; // Used in method WriteUserShortDescription():counts cars owned by user.
        public string PhotoPath;


        public User()
        {
            UserCars = new List<Car>();
        }
        public User(string name, DateTime birthdate, string idNumber, string licenceNumber, DateTime licenceDate, string street, string postCode, string city)
        {
            Name = name;
            BirthDate = birthdate;
            IdNumber = idNumber;
            LicenceNumber = licenceNumber;
            LicenceDate = licenceDate;
            SetResidenceAddress(street, postCode, city);
            UserAge = GetUserAge();
            Street = street;
            PostCode = postCode;
            City = city;
            UserCars = new List<Car>();
        }

        /// <summary>
        /// Method adds new car to the user's car list "userCars".
        /// </summary>
        /// <param name="newCar"></param>
        public void AddNewCar(Car newCar)
        {
            UserCars.Add(newCar);
        }

        /// <summary>
        /// Finds car in user's car list by Brand, Model and ProductionYear.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="productionYear"></param>
        /// <returns></returns>
        public List<Car> FindCar(string brand, string model, int productionYear)
        {
            try
            {
                var foundCar = UserCars
                    .Where(c => c.Brand == brand)
                    .Where(c => c.Model == model)
                    .Where(c => c.ProductionDate.Year == productionYear);
                return new List<Car>(foundCar);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Car could not be found!", "Failure!");
                return new List<Car>();
            }

            //List<int> brandList = FindCarBrand(brand);
            //List<int> modelList = FindCarModel(model);
            //List<int> yearList = FindCarYear(productionYear);
            //List<int> foundCars = CompareLists(brandList, modelList, yearList);

        }
        public Car FindCarByVin(string vin)
        {
            try
            {
                var car = UserCars.First(c => c.Vin == vin);
                return car;
            }
            catch (Exception)
            {
                MessageBox.Show("Car could not be found!", "Failure!");
                return new Car();
            }

        }


        /// <summary>
        /// Removes car from user's car list by Brand, Model, ProductionYear.
        /// </summary>
        /// <param name="Brand"></param>
        /// <param name="Model"></param>
        /// <param name="ProductionYear"></param>
        public void RemoveCar(String vin)
        {
            try
            {
                UserCars.Remove(UserCars.First(c => c.Vin == vin));
                MessageBox.Show("Car deleted!", "Success!");
            }
            catch (Exception)
            {
                MessageBox.Show("Car could not be found!", "Failure");
            }


        }


        /// <summary>
        /// Returns user's car list "userCars".
        /// </summary>
        /// <returns></returns>
        public List<Car> RetrieveCars()
        {
            return UserCars;
        }

        /// <summary>
        /// Writes short description of a user. Name, age, number of owned cars.
        /// </summary>
        /// <returns></returns>
        public string WriteUserShortDescription()
        {
            UserAge = GetUserAge();
            UserOwnedCars = UserCars.Count();
            UserDescription = string.Format("{0},{1},{2}", Name, UserAge, UserOwnedCars);
            return UserDescription;
        }

        /// <summary>
        /// Returns age of user.
        /// </summary>
        /// <returns></returns>
        public int GetUserAge()
        {
            DateTime dateToday = DateTime.Today;
            UserAge = dateToday.Year - BirthDate.Year;
            if (BirthDate > dateToday.AddYears(-UserAge))
            {
                UserAge--;
            }
            return UserAge;
        }


        /// <summary>
        /// Sets user "Name surname".
        /// </summary>
        /// <param name="nameInput"></param>
        public void SetName(string nameInput)
        {
            Name = nameInput;
        }
        /// <summary>
        /// Returns "Name surname" of user.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return Name;
        }
        /// <summary>
        /// Sets user's birthdate.
        /// </summary>
        /// <param name="birthInput"></param>
        public void SetBirthdate(DateTime birthInput)
        {
            BirthDate = birthInput;
        }
        /// <summary>
        /// Returns user's birthdate.
        /// </summary>
        /// <returns></returns>
        public DateTime GetBirthdate()
        {
            return BirthDate;
        }
        /// <summary>
        /// Sets user's ID number.
        /// </summary>
        /// <param name="idInput"></param>
        public void SetIdNumber(string idInput)
        {
            IdNumber = idInput;
        }
        /// <summary>
        /// Returns user's ID number.
        /// </summary>
        /// <returns></returns>
        public string GetIdNumber()
        {
            return IdNumber;
        }
        /// <summary>
        /// Sets licence
        /// </summary>
        /// <param name="plateInput"></param>
        public void SetLicenceNumber(string licenceNrInput)
        {
            LicenceNumber = licenceNrInput;
        }
        /// <summary>
        /// Returns user's licence number.
        /// </summary>
        /// <returns></returns>
        public string GetLicenceNumber()
        {
            return LicenceNumber;
        }
        /// <summary>
        /// Sets date of issue of the driver's licence.
        /// </summary>
        /// <param name="dateInput"></param>
        public void SetLicenceDate(DateTime dateInput)
        {
            LicenceDate = dateInput;
        }
        /// <summary>
        /// Returns date of issue of the driver's licence.
        /// </summary>
        /// <returns></returns>
        public DateTime GetLicenceDate()
        {
            return LicenceDate;
        }

        /// <summary>
        /// Sets user's residence address.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="postCode"></param>
        /// <param name="city"></param>
        public void SetResidenceAddress(string street, string postCode, string city)
        {
            ResidenceAddress = string.Format("{0},{1},{2}", street, postCode, city);
        }
        /// <summary>
        /// Returns user's residence address in format "street,post code,city".
        /// </summary>
        /// <returns></returns>
        public string GetResidenceAddress()
        {
            return ResidenceAddress;
        }

        public void SetPhotoPath(string path)
        {
            PhotoPath = path;
        }
        public string GetPhotoPath()
        {
            return PhotoPath;
        }
        ///// <summary>
        ///// Edits users existing data, if bool == true, then enter new data to edit.
        ///// </summary>
        ///// <param name="nameB"></param>
        ///// <param name="birthB"></param>
        ///// <param name="idNumberB"></param>
        ///// <param name="licenceNumberB"></param>
        ///// <param name="addressB"></param>
        ///// <param name="name"></param>
        ///// <param name="birthdate"></param>
        ///// <param name="idNumber"></param>
        ///// <param name="licenceNumber"></param>
        ///// <param name="street"></param>
        ///// <param name="postCode"></param>
        ///// <param name="city"></param>
        //public void EditUserSpecifiedData(bool nameB, bool birthB, bool idNumberB, bool licenceNumberB, bool addressB, 
        //    string name, DateTime birthdate, string idNumber, string licenceNumber, string street, string postCode, string city)
        //{
        //    if (nameB)
        //    {
        //        SetName(name);
        //        //MessageBox.Show("User's name edit successful!", "Success!", MessageBoxButtons.OK);
        //    }
        //    if (birthB)
        //    {
        //        SetBirthdate(birthdate);
        //        //MessageBox.Show("User's birth date edit successful!", "Success!",MessageBoxButtons.OK);
        //    }
        //    if (idNumberB)
        //    {
        //        SetIdNumber(idNumber);
        //        //MessageBox.Show("User's ID number edit successful!", "Success!", MessageBoxButtons.OK);
        //    }
        //    if (licenceNumberB)
        //    {
        //        SetLicenceNumber(licenceNumber);
        //        //MessageBox.Show("Driver's licence number edit successful!", "Success!", MessageBoxButtons.OK);
        //    }
        //    if (addressB)
        //    {
        //        SetResidenceAddress(street, postCode, city);
        //        //MessageBox.Show("User's residence address edit successful!", "Success!", MessageBoxButtons.OK);
        //    }
        //}
    }
}
