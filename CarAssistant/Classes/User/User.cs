using System;
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
        public string idNumber;
        /// <summary>
        /// Number of user's driving licence.
        /// </summary>
        public string licenceNumber;
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
        public int userAge; // Used in method WriteUserShortDescription(): calculates user's age in years
        private int userOwnedCars; // Used in method WriteUserShortDescription():counts cars owned by user.
        private string photoPath;

        public User(string name, DateTime birthdate, string idNumber, string licenceNumber, DateTime licenceDate, string street, string postCode, string city)
        {
            userCars = new List<Car>();
            this.name = name;
            birthDate = birthdate;
            this.idNumber = idNumber;
            this.licenceNumber = licenceNumber;
            this.licenceDate = licenceDate;
            SetResidenceAddress(street, postCode, city);
            userAge = GetUserAge();
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
		public List<Car> FindCar(string Brand, string Model, int ProductionYear)
        {
            List<int> brandList = FindCarBrand(Brand);
            List<int> modelList = FindCarModel(Model);
            List<int> yearList = FindCarYear(ProductionYear);
            List<int> foundCars = CompareLists(brandList, modelList, yearList);
            return FoundCars(foundCars);
            
        }
        public Car FindCarByVin(string vin)
        {
            Car car = null;
            for (int i = 0; i < userCars.Count(); i++)
            {
                if (vin == userCars[i].GetVin())
                {
                    car = userCars[i];
                    break;
                }
            }
            return car;
        }
        private List<Car> FoundCars(List<int> list)
        {
            Car car;
            List<Car> cars = new List<Car>();
            if (list.Count() == 0)
            {
                MessageBox.Show("Car could not be found!", "Please try again with another parameters!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return cars;
            }
            else
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    car = userCars[list[i]];
                    cars.Add(car);
                }
                return cars;
            }
        }
        private List<int> CompareLists(List<int> list1, List<int> list2, List<int> list3)
        {
            List<int> first = list1.Intersect(list2).ToList();
            List<int> result = first.Intersect(list3).ToList();
            return result;
        }

        /// <summary>
        /// Removes car from user's car list by Brand, Model, ProductionYear.
        /// </summary>
        /// <param name="Brand"></param>
        /// <param name="Model"></param>
        /// <param name="ProductionYear"></param>
		public void RemoveCar(String vin)
        {
            bool delete = false;

            delete = DeleteCar(vin);
            ShowDeleteMessage(delete);
        }
        private bool DeleteCar(string vin)
        {
            bool delete = false;
            for (int i = 0; i < userCars.Count(); i++)
            {
                if (vin == userCars[i].GetVin())
                {
                    userCars.Remove(userCars[i]);
                    delete = true;
                    break;
                }
                else
                {
                    delete = false;
                }
            }

            return delete;
        }
        private List<int> FindCarBrand(string brand)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < userCars.Count(); i++)
            {
                if (brand == userCars[i].GetBrand())
                {
                    list.Add(i);
                }
            }
            return list;
        }
        private List<int> FindCarModel(string model)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < userCars.Count(); i++)
            {
                if (model == userCars[i].GetModel())
                {
                    list.Add(i);
                }
            }
            return list;
        }
        private List<int> FindCarYear(int ProductionYear)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < userCars.Count(); i++)
            {
                if (ProductionYear == userCars[i].GetProductionDate().Year)
                {
                    list.Add(i);
                }
            }
            return list;
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
        public void SetUserAge(int age)
        {
            userAge = age;
        }
        /// <summary>
        /// Sets user "Name surname".
        /// </summary>
        /// <param name="nameInput"></param>
        public void SetName(string nameInput)
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
        public void SetBirthdate(DateTime BirthInput)
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
        public void SetIdNumber(string idInput)
        {
            idNumber = idInput;
        }
        /// <summary>
        /// Returns user's ID number.
        /// </summary>
        /// <returns></returns>
        public string GetIdNumber()
        {
            return idNumber;
        }
        /// <summary>
        /// Sets licence
        /// </summary>
        /// <param name="plateInput"></param>
        public void SetLicenceNumber(string licenceNrInput)
        {
            licenceNumber = licenceNrInput;
        }
        /// <summary>
        /// Returns user's licence number.
        /// </summary>
        /// <returns></returns>
        public string GetLicenceNumber()
        {
            return licenceNumber;
        }
        /// <summary>
        /// Sets date of issue of the driver's licence.
        /// </summary>
        /// <param name="dateInput"></param>
        public void SetLicenceDate(DateTime dateInput)
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
        public void SetResidenceAddress(string street, string postCode, string city)
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

        public void SetPhotoPath(string path)
        {
            photoPath = path;
        }
        public string GetPhotoPath()
        {
            return photoPath;
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
            string name, DateTime birthdate, string idNumber, string licenceNumber, string street, string postCode, string city)
        {
            if (nameB)
            {
                SetName(name);
                //MessageBox.Show("User's name edit successful!", "Success!", MessageBoxButtons.OK);
            }
            if (birthB)
            {
                SetBirthdate(birthdate);
                //MessageBox.Show("User's birth date edit successful!", "Success!",MessageBoxButtons.OK);
            }
            if (idNumberB)
            {
                SetIdNumber(idNumber);
                //MessageBox.Show("User's ID number edit successful!", "Success!", MessageBoxButtons.OK);
            }
            if (licenceNumberB)
            {
                SetLicenceNumber(licenceNumber);
                //MessageBox.Show("Driver's licence number edit successful!", "Success!", MessageBoxButtons.OK);
            }
            if (addressB)
            {
                SetResidenceAddress(street, postCode, city);
                //MessageBox.Show("User's residence address edit successful!", "Success!", MessageBoxButtons.OK);
            }
        }
	}
}
