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
        private string _name, _street, _city, _postCode, _idNumber, _licenceNumber;
        private DateTime _birthDate, _licenceRelease;
        private User _driver;
        private Form1 _form1;
        bool _userBool = false;
        private string _directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CarAssistant\\files";
        UserManager _userManager = new UserManager();

        public FormCreateUser(Form1 form)
        {
            InitializeComponent();
            _form1 = form;
        }

        private void bDriverPhoto_Click(object sender, EventArgs e)
        {
            //path = "";
            OpenFile(_directory);
        }
        private void bCreateDriver_Click(object sender, EventArgs e)
        {
            //string pathxml = @"c:\CarAssistant\user.xml";
            _driver = CreateUser();
            _driver.SetPhotoPath(_directory+"\\user.jpg");
            DataSaver save = new DataSaver();
            save.SaveUserToXml(_driver, _directory+"\\user.xml");
            _form1.Driver = _driver;
            _form1.UpdateUserForms(_driver);
            CloseForm();
        }
        private void CloseForm()
        {
            if (_userBool)
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
            _driver = new User(_name,_birthDate,_idNumber,_licenceNumber,_licenceRelease,_street,_postCode,_city);
            _userBool = true;
            }
            catch
            {
                MessageBox.Show("Something gone wrong!", "Error");
            }
            return _driver;
        }
        public void GetValuesToCreateUser()
        {
            ReadTextboxes(out _name, out _birthDate, out _idNumber, out _licenceNumber, out _licenceRelease, out _street, out _postCode, out _city);
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
