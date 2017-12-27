using System;
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
using CarAssistant.Classes.Expenses;
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
        BindingSource CarsToShow = new BindingSource();

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
            UpdateExpensesComboBox();
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
                    UpdateUserForms(driver);
                }
                else
                    MessageBox.Show("Car list not loaded");

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
            CarsToShow.Clear();
            List<Car> ListToShow = driver.userCars;
            foreach(Car c in ListToShow)
            {
                CarsToShow.Add(c);
            }
            dgShowCars.Columns[6].DefaultCellStyle.Format = "yyyy";            
            dgShowCars.DataSource = CarsToShow;
            
        }

        private void dgShowCars_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgShowCars.Rows)
                {            
                    if (Convert.ToBoolean(row.Cells[0].Selected) == true)
                    {
                        row.Selected = true;
                    }
                }
            }            
        }

        private void bShowDetails_Click(object sender, EventArgs e)
        {
            if (GetCheckedRow() != null)
            {
            Car DetailedCar = GetCarToDetail(GetCheckedRow());
            MenagePanelCarDetails(DetailedCar);
            panelCarDetails.BringToFront();
            }

        }

        private DataGridViewRow GetCheckedRow()
        {
            int HowManyChecked = 0;
            DataGridViewRow Checked = new DataGridViewRow();
            Checked = null;
            foreach (DataGridViewRow row in dgShowCars.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    HowManyChecked++;
                    Checked =row;                    
                }              
            }
            if(HowManyChecked == 0)
            {
                Checked = null;
                MessageBox.Show("None of the cars were choosen. Please choose one", "Alarm!", MessageBoxButtons.OK);
            }
            else if(HowManyChecked > 1)
            {
                Checked = null;
                MessageBox.Show("Too many cars were choosen. Please choose one", "Alarm!", MessageBoxButtons.OK);
            }
            
            return Checked;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            ShowCarsInGridBox();
            panelCars.BringToFront();
        }

        private Car GetCarToDetail(DataGridViewRow CheckedRow)
        {
            Car ToReturn = new Car();
                foreach(Car c in driver.userCars)
                {
                    if (c.Index.ToString() == CheckedRow.Cells["cIndex"].Value.ToString() &&
                        c.Brand.ToString() == CheckedRow.Cells["cBrand"].Value.ToString() &&
                        c.Model.ToString() == CheckedRow.Cells["cModel"].Value.ToString() &&
                        c.BodyType.ToString() == CheckedRow.Cells["cBodyType"].Value.ToString() &&
                        c.LicensePlateNo.ToString() == CheckedRow.Cells["CLicensePlateNo"].Value.ToString() &&
                        c.ProductionDate.ToString() == CheckedRow.Cells["CProductionYear"].Value.ToString())
                    {
                        ToReturn = c;
                        return ToReturn;
                    }
                }
            return null;
        }

        private void MenagePanelCarDetails(Car Show)
        {
            tbDBrand.Text = Show.Brand.ToString();
            tbDModel.Text = Show.Model.ToString();
            tbDProductionYear.Text = Show.ProductionDate.Year.ToString();
            tbDPurchaseYear.Text = Show.GetPurchaseDate().ToString();
            tbDLicencePlateNo.Text = Show.LicensePlateNo.ToString();
            tbDVIN.Text = Show.GetVin();
            tbDBodyType.Text = Show.BodyType.ToString();

            Engine FromShow = Show.GetEngine();
            tbDEngineType.Text = FromShow.TypeOfEngine;
            tbDCapacity.Text = FromShow.Capacity.ToString();
            tbDPowerHP.Text = FromShow.Horsepower.ToString();
            tbDPowerkW.Text = FromShow.PowerInKW.ToString();
        }





        private void GeneratingDataForTests()
        {
            Repairs repair1 = new Repairs(1250M, "Uszczelka pod głowica", new DateTime(2017, 12, 01), "U pana Stasia");
            Insurance insurance1 = new Insurance(1500M, "OC", new DateTime(2017, 05, 11), true, new DateTime(2018, 05, 10), "PSU S.A.");
            Service service = new Service(750M, "Distribution system fix", new DateTime(2017, 12, 01), "Zenek Serwis");
            LooksMaintenance looks1 = new LooksMaintenance(12.50M, "Pranie tapicerki", new DateTime(2017, 12, 01),"Added wunderbaum");
            Exploitation explo1 = new Exploitation(1250M, "Tyres changed", new DateTime(2017, 12, 01), "355/25R1 107 Y Pirelli PZERO");
            dataGridView1.Update();
        }

        private void bEditCar_Click(object sender, EventArgs e)
        {
            Car CarToEdit = GetCarToDetail(GetCheckedRow());

        }

        private void UpdateExpensesComboBox()
        {
            string CarName = "";
            foreach (var Car in driver.userCars)
            {
                CarName = string.Format("{0}, {1}, {2}",Car.Brand.ToString(), Car.Model.ToString(), Car.ProductionDate.Year.ToString());
                cbWhichCar.Items.Add(CarName);
            }
        }
    }
}
