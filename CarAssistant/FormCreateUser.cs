using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CarAssistant.Classes.Facade;

namespace CarAssistant
{
    public partial class FormCreateUser : Form
    {
        private string name, street, city, postCode, idNumber, licenceNumber;
        private DateTime birthDate, licenceRelease;
        private User driver;
        bool userBool = false;
        private string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CarAssistant\\files";
        UserManager userManager = new UserManager();

        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void bDriverPhoto_Click(object sender, EventArgs e)
        {
            //path = "";
            OpenFile(directory);
        }
        private void bCreateDriver_Click(object sender, EventArgs e)
        {
            //string pathxml = @"c:\CarAssistant\user.xml";
            driver = CreateUser();
            driver.SetPhotoPath(directory+"\\user.jpg");
            DataSaver save = new DataSaver();
            save.SaveUserToXml(driver, directory+"\\user.xml");
            CloseForm();
        }
        private void CloseForm()
        {
            if (userBool)
            {
                Close();
            }
        }

        private void OpenFile(string path)
        {
            try
            {
                OpenFileDialog loadUserImage = new OpenFileDialog();
                loadUserImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (loadUserImage.ShowDialog() == DialogResult.OK)
                {
                    string imageLocation = loadUserImage.FileName;
                    File.Copy(imageLocation, path+"\\user.jpg", true);
                    pbUserImageLoad.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("Wrong file path.", "error", MessageBoxButtons.OK);
            }
        }

        public User CreateUser()
        {
            try
            {
            GetValuesToCreateUser();
            driver = new User(name,birthDate,idNumber,licenceNumber,licenceRelease,street,postCode,city);
            userBool = true;
            }
            catch
            {
                MessageBox.Show("Something gone wrong!", "Error");
            }
            return driver;
        }
        public void GetValuesToCreateUser()
        {
            ReadTextboxes(out name, out birthDate, out idNumber, out licenceNumber, out licenceRelease, out street, out postCode, out city);
        }
        public void ReadTextboxes(out string name, out DateTime birthDate, out string idNumber, out string licenceNumber, out DateTime licenceRelease, out string street, out string postCode, out string city )
        {
            name = tbCreateName.Text;
            birthDate = ConvertToDatetime(dateBirthDate.Text);
            idNumber = tbCreateIdnumb.Text;
            licenceNumber = tbCreateLicenceNr.Text;
            licenceRelease = ConvertToDatetime(dateLicRelease.Text);
            street = tbCreateStreet.Text;
            postCode = tbCreatePostCode.Text;
            city = tbCreateCity.Text;
        }

        private DateTime ConvertToDatetime(string date)
        {
            DateTime convertedDate = new DateTime();
            try
            {
                convertedDate = DateTime.ParseExact(date, "dd-MM-yyyy", null);
            }
            catch
            {
                MessageBox.Show("Wrong format of date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return convertedDate;
        }
        private int ConvertToInt(string id)
        {
            int convertedInt = 0;
            try
            {
                convertedInt = int.Parse(id);
            }
            catch
            {
                MessageBox.Show("Wrong format. Use numbers only!", "Something gone wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return convertedInt;
        }
    }
}
