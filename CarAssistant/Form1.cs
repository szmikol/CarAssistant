﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarAssistant.Classes.Facade;
using CarAssistant.Classes.Car;
using CarAssistant.Interfaces;
using System.IO;
using System.Globalization;


namespace CarAssistant
{
	public partial class Form1 : Form
	{
        public User driver;
        private string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CarAssistant\\files";
        DataSaver dataSaver;
        DataLoader dataLoader;
        Dictionary<string, string[]> brandsAndModels = BrandsAndModels.GetResources();
        

    public Form1()
		{
			InitializeComponent();
            CreateFilesAndDirectories();
            InitialDriverLoader(out driver);
            InitialLoadCarList();
            ShowStartingScreen();

            //foreach (var item in brandsAndModels.Keys)
            //{
            //    cbBrand.Items.Add(item);
            //}
        }


        private void bExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void bCars_Click(object sender, EventArgs e)
        {
            panelCars.BringToFront();
            ChangeActiveButtonColor(bCars);
        }

        private void bManage_Click(object sender, EventArgs e)
        {
            panelManage.BringToFront();
            ChangeActiveButtonColor(bManage);
        }

        private void bService_Click(object sender, EventArgs e)
        {
            panelService.BringToFront();
            ChangeActiveButtonColor(bService);
        }

        private void bInsurance_Click(object sender, EventArgs e)
        {
            panelInsurance.BringToFront();
            ChangeActiveButtonColor(bInsurance);
        }

        private void bRefuel_Click(object sender, EventArgs e)
        {
            panelRefuel.BringToFront();
            ChangeActiveButtonColor(bRefuel);
        }

        private void bExpenses_Click(object sender, EventArgs e)
        {
            panelExpenses.BringToFront();
            ChangeActiveButtonColor(bExpenses);
        }

        private void bReminders_Click(object sender, EventArgs e)
        {
            panelReminders.BringToFront();
            ChangeActiveButtonColor(bReminders);
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            panelSettings.BringToFront();
            ChangeActiveButtonColor(bSettings);
        }
        private void bSaveLoad_Click(object sender, EventArgs e)
        {
            panelSaveLoad.BringToFront();
            ChangeActiveButtonColor(bSaveLoad);
        }

        private void Exit()
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        private void ShowStartingScreen()
        {
            panelStart.BringToFront();
        }

        private void ChangeActiveButtonColor(Button button)
        {
            bCars.ForeColor = Color.White;
            bManage.ForeColor = Color.White;
            bService.ForeColor = Color.White;
            bInsurance.ForeColor = Color.White;
            bRefuel.ForeColor = Color.White;
            bExpenses.ForeColor = Color.White;
            bReminders.ForeColor = Color.White;
            bSaveLoad.ForeColor = Color.White;
            bSettings.ForeColor = Color.White;
            bExit.ForeColor = Color.White;
            button.ForeColor = Color.Green;
        }

        private void bLoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader loadStream = new StreamReader(openFileDialog1.FileName);
                MessageBox.Show(loadStream.ReadToEnd());
                loadStream.Close();
            }
        }

        private void bSaveFile_Click(object sender, EventArgs e)
        {

        }

        private void bHome_Click(object sender, EventArgs e)
        {
            panelStart.BringToFront();
            ChangeActiveButtonColor(bHome);
        }

        private void bCreateDriver_Click(object sender, EventArgs e)
        {
            FormCreateUser formCreateUser = new FormCreateUser();
            formCreateUser.Show();
        }
        public void UpdateUserForms(User user)
        {
            tbDrPName.Text = user.GetName();
            tbDrPAge.Text = user.GetUserAge().ToString();
            tbDrPBirthdate.Text = user.GetBirthdate().ToShortDateString();
            tbDrPIDNumber.Text = user.GetIdNumber();
            tbDrPLicenceNumber.Text = user.GetLicenceNumber();
            tbDrPOwnedCars.Text = (0 + user.userCars.Count()).ToString();
            tbDrPAddress.Text = ResidenceStringSplit(user.GetResidenceAddress());
        }
        private string ResidenceStringSplit(string toSplit)
        {
            int i = 0;
            string[] splitted = toSplit.Split(',');
            string street = splitted[i];
            string postCode = splitted[i + 1];
            string city = splitted[i + 2];
            string result = street + Environment.NewLine;
            result += postCode + Environment.NewLine;
            result += city + Environment.NewLine;
            return result;
        }
        public void SetDriverPath(User user)
        {
            driver = user;
        }
        private void InitialDriverLoader(out User driver)
        {
            if (File.Exists(directory+"\\user.xml"))
            {
                LoadingImageIfExist();
                string path = directory + "\\user.xml";
                driver = dataLoader.LoadUserFromXml(path);
                UpdateUserForms(driver);
            }
            else
            {
                driver = null;
            }

        }
        private void InitialLoadCarList()
        {
            if(driver != null)
            {
                if (File.Exists(directory + "\\carlist.xml"))
                {
                    driver.userCars = dataLoader.LoadCarsListFromXml(directory + "\\carlist.xml");
                    ShowCarsInGridBox();
                    
                }

            }
        }
        private void LoadingImageIfExist()
        {
            if (File.Exists(directory + "\\user.jpg"))
            {
                picUserPhoto.Image = Image.FromFile(directory +"\\user.jpg");
            }
            else
            {
                picUserPhoto.Image = Properties.Resources.BlankProfile;
            }
        }
        private void CreateFilesAndDirectories()
        {
            Directory.CreateDirectory(directory);
            dataSaver = new DataSaver();
            dataLoader = new DataLoader();
        }

        private void bAddCar_Click(object sender, EventArgs e)
        {
            
            foreach (var item in brandsAndModels.Keys)
            {
                cbBrand.Items.Add(item);
            }
            panelAddNewCar.BringToFront();
        }

        private void bCreateCar_Click(object sender, EventArgs e)
        {                    
            Car CarFromPanel = new Car();
            CarFromPanel = CreateCarFromPanel();
            driver.userCars.Add(CarFromPanel);
            ClearAddNewCarPanel();
            ShowCarsInGridBox();
            dataSaver.SaveCarsListToXml(driver.userCars, directory+"\\carlist.xml");
            panelCars.BringToFront();
        }

        private void bShowCars_Click(object sender, EventArgs e)
        {
            if(driver == null)
            {
                MessageBox.Show("No user, no cars. Please Load User first", "Achtung!", MessageBoxButtons.OK);

            }
            else if (driver.userCars.Count() == 0)
            {
                MessageBox.Show("User has no cars yet. Please add some cars", "Achtung!", MessageBoxButtons.OK);
            }
            else
            {
                dgShowCars.Refresh();
                ShowCarsInGridBox();
            }

        }

        private Car CreateCarFromPanel()
        {
            Car Temp = new Car();
            
            DateTime TempProductionYear = DateTime.ParseExact(tbProductionYear.Text, "yyyy", CultureInfo.InvariantCulture);
            DateTime TempPurchaseDate = dtPurchaseDate.Value;
            double TempCounterState = double.Parse(tbCounterState.Text);
            int TempCapacity = int.Parse(tbCapacity.Text);
            int TempHorsePower = int.Parse(tbPower.Text);
            string TempTypeOfEngine = cbEngineType.Text;

            Temp.Brand = (cbBrand.SelectedItem.ToString());
            Temp.Model = (cbModel.SelectedItem.ToString());
            Temp.ProductionDate = (TempProductionYear);
            Temp.SetPurchaseDate(TempPurchaseDate);
            Temp.SetCounterState(TempCounterState);
            Temp.LicensePlateNo = (tbLicensePlates.Text);
            Temp.SetVin(tbVIN.Text);
            Temp.BodyType = (cbBodyType.SelectedItem.ToString());
            Temp.SetOwner(driver);
            Temp.SetIndex();

            Engine EForTemp = new Engine (TempCapacity, TempHorsePower, TempTypeOfEngine);
            Temp.SetEngine(EForTemp);


            return Temp;
        }

        private void cbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbModel.Items.Clear();

            if (cbBrand.SelectedIndex > -1)
            {
                string brand = brandsAndModels.Keys.ElementAt(cbBrand.SelectedIndex);
                cbModel.Items.AddRange(brandsAndModels[brand]);
            }

        }
        private void ClearAddNewCarPanel()
        {
            cbBrand.Items.Clear();
            cbModel.SelectedIndex = -1;
            cbEngineType.SelectedIndex = -1;
            cbBodyType.SelectedIndex = -1;
            tbCounterState.Clear();
            tbLicensePlates.Clear();
            tbPower.Clear();
            tbProductionYear.Clear();
            tbVIN.Clear();
            dtPurchaseDate.Value = DateTime.Now;
            tbCapacity.Clear();
        }
        private void ShowCarsInGridBox()
        {
            List<Car> ListToShow = driver.userCars;
            dgShowCars.Columns[6].DefaultCellStyle.Format = "yyyy";
            dgShowCars.Refresh();
            dgShowCars.DataSource = ListToShow;
        }
        
    }
}
