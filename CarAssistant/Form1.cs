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
        public User Driver;

        private string _directory =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CarAssistant\\files";

        DataSaver _dataSaver;
        DataLoader _dataLoader;
        Dictionary<string, string[]> _brandsAndModels = BrandsAndModels.GetResources();
        BindingSource _carsToShow = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            CreateFilesAndDirectories();
            InitialDriverLoader(out Driver);
            InitialLoadCarList();
            ShowStartingScreen();
            UpdateUserForms(Driver);
            //GeneratingDataForTests();
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
            panelExpButtons.BringToFront();
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
            FormCreateUser formCreateUser = new FormCreateUser(this);
            formCreateUser.Show();
        }

        public void UpdateUserForms(User user)
        {
            if (user != null)
            {
                tbDrPName.Text = user.GetName();
                tbDrPAge.Text = user.GetUserAge().ToString();
                tbDrPBirthdate.Text = user.GetBirthdate().ToShortDateString();
                tbDrPIDNumber.Text = user.GetIdNumber();
                tbDrPLicenceNumber.Text = user.GetLicenceNumber();
                tbDrPOwnedCars.Text = (0 + user.UserCars.Count()).ToString();
                tbDrPAddress.Text = ResidenceStringSplit(user.GetResidenceAddress());
            }
            LoadingImageIfExist();

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
            Driver = user;
        }

        private void InitialDriverLoader(out User driver)
        {
            if (File.Exists(_directory + "\\user.xml"))
            {
                LoadingImageIfExist();
                string path = _directory + "\\user.xml";
                driver = _dataLoader.LoadUserFromXml(path);
            }
            else
            {
                driver = null;
            }

        }

        private void InitialLoadCarList()
        {
            if (Driver != null)
            {
                if (File.Exists(_directory + "\\carlist.xml"))
                {
                    Driver.UserCars = _dataLoader.LoadCarsListFromXml(_directory + "\\carlist.xml");
                    ShowCarsInGridBox();
                }
                else
                    MessageBox.Show("Car list not loaded");

            }
        }

        private void LoadingImageIfExist()
        {
            if (File.Exists(_directory + "\\user.jpg"))
            {
                picUserPhoto.Image = Image.FromFile(_directory + "\\user.jpg");
            }
            else
            {
                picUserPhoto.Image = Properties.Resources.BlankProfile;
            }
        }

        private void CreateFilesAndDirectories()
        {
            Directory.CreateDirectory(_directory);
            _dataSaver = new DataSaver();
            _dataLoader = new DataLoader();
        }

        private void bAddCar_Click(object sender, EventArgs e)
        {

            foreach (var item in _brandsAndModels.Keys)
            {
                cbBrand.Items.Add(item);
            }

            panelAddNewCar.BringToFront();
        }

        private void bCreateCar_Click(object sender, EventArgs e)
        {
            Car carFromPanel = new Car();
            carFromPanel = CreateCarFromPanel();
            Driver.UserCars.Add(carFromPanel);
            ClearAddNewCarPanel();
            ShowCarsInGridBox();
            SaveCarList();
            panelCars.BringToFront();
        }

        private void bShowCars_Click(object sender, EventArgs e)
        {
            if (Driver == null)
            {
                MessageBox.Show("No user, no cars. Please Load User first", "Achtung!", MessageBoxButtons.OK);

            }
            else if (Driver.UserCars.Count() == 0)
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
            Car temp = new Car();

            DateTime tempProductionYear =
                DateTime.ParseExact(tbProductionYear.Text, "yyyy", CultureInfo.InvariantCulture);
            DateTime tempPurchaseDate = dtPurchaseDate.Value;
            double tempCounterState = double.Parse(tbCounterState.Text);
            int tempCapacity = int.Parse(tbCapacity.Text);
            int tempHorsePower = int.Parse(tbPower.Text);
            string tempTypeOfEngine = cbEngineType.Text;

            temp.Brand = (cbBrand.SelectedItem.ToString());
            temp.Model = (cbModel.SelectedItem.ToString());
            temp.ProductionDate = (tempProductionYear);
            temp.SetPurchaseDate(tempPurchaseDate);
            temp.SetCounterState(tempCounterState);
            temp.LicensePlateNo = (tbLicensePlates.Text);
            temp.SetVin(tbVIN.Text);
            temp.BodyType = (cbBodyType.SelectedItem.ToString());
            temp.SetOwner(Driver);
            temp.SetIndex();

            Engine eForTemp = new Engine(tempCapacity, tempHorsePower, tempTypeOfEngine);
            temp.SetEngine(eForTemp);


            return temp;
        }

        private void cbBrand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbModel.Items.Clear();

            if (cbBrand.SelectedIndex > -1)
            {
                string brand = _brandsAndModels.Keys.ElementAt(cbBrand.SelectedIndex);
                cbModel.Items.AddRange(_brandsAndModels[brand]);
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
            _carsToShow.Clear();
            List<Car> listToShow = Driver.UserCars;
            foreach (Car c in listToShow)
            {
                _carsToShow.Add(c);
            }

            dgShowCars.Columns[6].DefaultCellStyle.Format = "yyyy";
            dgShowCars.DataSource = _carsToShow;

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
                Car detailedCar = GetCarToDetail(GetCheckedRow());
                MenagePanelCarDetails(detailedCar);
                panelCarDetails.BringToFront();
            }

        }

        private DataGridViewRow GetCheckedRow()
        {
            int howManyChecked = 0;
            DataGridViewRow Checked = new DataGridViewRow();
            Checked = null;
            foreach (DataGridViewRow row in dgShowCars.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    howManyChecked++;
                    Checked = row;
                }
            }

            if (howManyChecked == 0)
            {
                Checked = null;
                MessageBox.Show("None of the cars were choosen. Please choose one", "Alarm!", MessageBoxButtons.OK);
            }
            else if (howManyChecked > 1)
            {
                Checked = null;
                MessageBox.Show("Too many cars were choosen. Please choose one", "Alarm!", MessageBoxButtons.OK);
            }

            return Checked;
        }

        private List<DataGridViewRow> GetCarsToDelete()
        {
            int howManyChecked = 0;
            List<DataGridViewRow> checkedCars = new List<DataGridViewRow>();
            //CheckedCars = null;
            foreach (DataGridViewRow row in dgShowCars.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    howManyChecked++;
                    checkedCars.Add(row);
                }
            }

            if (howManyChecked == 0)
            {
                checkedCars = null;
                MessageBox.Show("None of the cars were choosen. Please choose one", "Alarm!", MessageBoxButtons.OK);
            }

            return checkedCars;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            ShowCarsInGridBox();
            panelCars.BringToFront();
        }

        private Car GetCarToDetail(DataGridViewRow checkedRow)
        {
            Car toReturn = new Car();
            foreach (Car c in Driver.UserCars)
            {
                if (c.Index.ToString() == checkedRow.Cells["cIndex"].Value.ToString() &&
                    c.Brand.ToString() == checkedRow.Cells["cBrand"].Value.ToString() &&
                    c.Model.ToString() == checkedRow.Cells["cModel"].Value.ToString() &&
                    c.BodyType.ToString() == checkedRow.Cells["cBodyType"].Value.ToString() &&
                    c.LicensePlateNo.ToString() == checkedRow.Cells["CLicensePlateNo"].Value.ToString() &&
                    c.ProductionDate.ToString() == checkedRow.Cells["CProductionYear"].Value.ToString())
                {
                    toReturn = c;
                    return toReturn;
                }
            }

            return null;
        }

        private void MenagePanelCarDetails(Car show)
        {
            tbDBrand.Text = show.Brand.ToString();
            tbDModel.Text = show.Model.ToString();
            tbDProductionYear.Text = show.ProductionDate.Year.ToString();
            tbDPurchaseYear.Text = show.GetPurchaseDate().ToString();
            tbDLicencePlateNo.Text = show.LicensePlateNo.ToString();
            tbDVIN.Text = show.GetVin();
            tbDBodyType.Text = show.BodyType.ToString();

            Engine fromShow = show.GetEngine();
            tbDEngineType.Text = fromShow.TypeOfEngine;
            tbDCapacity.Text = fromShow.Capacity.ToString();
            tbDPowerHP.Text = fromShow.Horsepower.ToString();
            tbDPowerkW.Text = fromShow.PowerInKw.ToString();
        }

        private void PopulatePanelEditCar(Car toEdit)
        {
            tbEditBrand.Text = toEdit.Brand.ToString();
            tbEditModel.Text = toEdit.Model.ToString();
            dtpEditPurchaseDate.Value = toEdit.PurchaseDate;
            tbEditPY.Text = toEdit.ProductionDate.Year.ToString();
            tbEditLicensePlate.Text = toEdit.LicensePlateNo.ToString();
            tbEditVIN.Text = toEdit.GetVin();
            tbEditBodyType.Text = toEdit.BodyType.ToString();

            Engine fromToEdit = toEdit.GetEngine();
            tbEditEngineType.Text = fromToEdit.TypeOfEngine;
            tbEditCapacity.Text = fromToEdit.Capacity.ToString();
            tbEditPowerHP.Text = fromToEdit.Horsepower.ToString();
            tbEditPowerkW.Text = fromToEdit.PowerInKw.ToString();
        }




        //private void GeneratingDataForTests()
        //{
        //    Repairs repair1 = new Repairs(1250M, "Uszczelka pod głowica", new DateTime(2017, 12, 01), "U pana Stasia");
        //    Insurance insurance1 = new Insurance(1500M, "OC", new DateTime(2017, 05, 11), true, new DateTime(2018, 05, 10), "PSU S.A.");
        //    Service service = new Service(750M, "Distribution system fix", new DateTime(2017, 12, 01), "Zenek Serwis");
        //    LooksMaintenance looks1 = new LooksMaintenance(12.50M, "Pranie tapicerki", new DateTime(2017, 12, 01),"Added wunderbaum");
        //    Exploitation explo1 = new Exploitation(1250M, "Tyres changed", new DateTime(2017, 12, 01), "355/25R1 107 Y Pirelli PZERO");
        //    driver.userCars[0].Repairs.Add(repair1);
        //    driver.userCars[0].Services.Add(service);
        //    driver.userCars[1].Insurance.Add(insurance1);
        //    driver.userCars[1].LooksMaintenance.Add(looks1);
        //    driver.userCars[2].Exploitation.Add(explo1);
        //}

        private void bEditCar_Click(object sender, EventArgs e)
        {
            Car carToEdit = GetCarToDetail(GetCheckedRow());
            PopulatePanelEditCar(carToEdit);
            panelEditCar.BringToFront();
        }

        private void bSaveCars_Click(object sender, EventArgs e)
        {
            SaveCarList();
        }

        private void bBackFromEdit_Click(object sender, EventArgs e)
        {
            panelCarDetails.BringToFront();
        }

        private void bUpdateCar_Click(object sender, EventArgs e)
        {
            Car carToEdit = GetCarToDetail(GetCheckedRow());
            Car carAfterChanges = GetCarAfterChanges();

            if (carToEdit != carAfterChanges)
            {
                carToEdit.ChangeCarsParameters(carAfterChanges);
            }
            else
            {
                MessageBox.Show("Nothing has been changed", "Achtung!", MessageBoxButtons.OK);
            }

            PopulatePanelEditCar(carToEdit);
            panelCarDetails.BringToFront();
        }

        private Car GetCarAfterChanges()
        {
            Car temp = new Car();
            temp.Brand = tbEditBrand.Text;
            temp.Model = tbEditModel.Text;
            temp.PurchaseDate = dtpEditPurchaseDate.Value;
            temp.ProductionDate = DateTime.ParseExact(tbEditPY.Text, "yyyy", CultureInfo.InvariantCulture);
            temp.LicensePlateNo = tbEditLicensePlate.Text;
            temp.Vin = tbEditVIN.Text;
            temp.BodyType = tbEditBodyType.Text;
            //Temp.Owner = driver;
            Engine forTemp = new Engine(int.Parse(tbEditCapacity.Text), int.Parse(tbEditPowerHP.Text),
                tbEditEngineType.Text);
            temp.Engine = forTemp;
            return temp;
        }

        private void tbEditPowerHP_TextChanged(object sender, EventArgs e)
        {
            if (tbEditPowerHP.Text != null && tbEditPowerHP.Text != "0")
            {
                double converter = 0.73549875;
                double kW = (double.Parse(tbEditPowerHP.Text) * converter);
                Math.Round(kW, MidpointRounding.ToEven);
                int output = Convert.ToInt32(kW);
                if (tbEditPowerkW.Text != output.ToString())
                {
                    tbEditPowerkW.Text = output.ToString();
                }
            }
        }

        private void tbEditPowerkW_TextChanged(object sender, EventArgs e)
        {
            if (tbEditPowerkW.Text != null && tbEditPowerkW.Text != "0")
            {
                double converter = 0.73549875;
                double hp = (double.Parse(tbEditPowerkW.Text) / converter);
                Math.Round(hp, MidpointRounding.ToEven);
                int output = Convert.ToInt32(hp);
                if (tbEditPowerHP.Text != output.ToString())
                {
                    tbEditPowerHP.Text = output.ToString();
                }
            }
        }

        private void bExpExploitation_Click(object sender, EventArgs e)
        {
            panelExpExploitation.BringToFront();
        }

        private void bExpInsurance_Click(object sender, EventArgs e)
        {
            panelExpInsurance.BringToFront();
        }

        private void bExpMainten_Click(object sender, EventArgs e)
        {
            panelExpMainten.BringToFront();
        }

        private void bExpRepairs_Click(object sender, EventArgs e)
        {
            panelExpRepairs.BringToFront();
        }

        private void bExpService_Click(object sender, EventArgs e)
        {
            panelExpService.BringToFront();
        }

        private void bExpBack_Click(object sender, EventArgs e)
        {
            panelExpButtons.BringToFront();
        }

        private void bDeleteCar_Click(object sender, EventArgs e)
        {
            CarManager carManage = new CarManager();
            List<DataGridViewRow> carsToDelete = new List<DataGridViewRow>();
            List<Car> whichToDelete = new List<Car>();
            carsToDelete = GetCarsToDelete();
            foreach (DataGridViewRow r in carsToDelete)
            {
                whichToDelete.Add(GetCarToDetail(r));
            }

            if (whichToDelete.Count != 0)
            {
                foreach (Car c in whichToDelete)
                {
                    carManage.DeleteCar(Driver, c);
                }
            }

            dgShowCars.Refresh();
            ShowCarsInGridBox();

        }

        private void bLoadCarPhoto_Click(object sender, EventArgs e)
        {
            string fileName = tbVIN.Text;
            ChooseCarPhoto(_directory, fileName);
        }

        private void ChooseCarPhoto(string path, string fileNam)
        {
            try
            {
                string name = fileNam;
                OpenFileDialog loadCarImage = new OpenFileDialog();
                loadCarImage.Filter =
                    "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (loadCarImage.ShowDialog() == DialogResult.OK)
                {
                    string imageLocation = loadCarImage.FileName;
                    File.Copy(imageLocation, path + "\\"+ name + ".jpg", true);
                    pbCarPhoto.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("Wrong file path.", "error", MessageBoxButtons.OK);
            }
        }

        private void bEditDriver_Click(object sender, EventArgs e)
        {
            if (Driver != null)
            {
                panelEditDriver.BringToFront();
                tbEditName.Text = Driver.Name;
                dateEditBirthDate.Value = Driver.BirthDate;
                tbEditIdnumb.Text = Driver.IdNumber;
                tbEditLicenceNr.Text = Driver.LicenceNumber;
                dateEditLicRelease.Value = Driver.LicenceDate;
                tbEditStreet.Text = Driver.Street;
                tbEditPostCode.Text = Driver.PostCode;
                tbEditCity.Text = Driver.City;
                if (File.Exists(_directory + "\\user.jpg"))
                {
                    pbEditUserImageLoad.Image = Image.FromFile(_directory + "\\user.jpg");
                }
                else
                {
                    pbEditUserImageLoad.Image = Properties.Resources.BlankProfile;

                }
            }
            else
            {
                MessageBox.Show("There is no driver to edit!");
            }

        }

        private void bEditDriverApply_Click(object sender, EventArgs e)
        {
            Driver.Name = tbEditName.Text;
            Driver.BirthDate = dateEditBirthDate.Value;
            Driver.IdNumber = tbEditIdnumb.Text;
            Driver.LicenceNumber = tbEditLicenceNr.Text;
            Driver.LicenceDate = dateEditLicRelease.Value;
            Driver.SetResidenceAddress(tbEditStreet.Text, tbEditPostCode.Text, tbEditCity.Text);
            UpdateUserForms(Driver);
            panelStart.BringToFront();
        }
        private void SaveCarList()
        {
            _dataSaver.SaveCarsListToXml(Driver.UserCars, _directory + "\\carlist.xml");
            MessageBox.Show("Cars have been saved", "Much Success", MessageBoxButtons.OK);
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
                    File.Copy(imageLocation, path + "\\user.jpg", true);
                    pbEditUserImageLoad.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("Wrong file path.", "error", MessageBoxButtons.OK);
            }
        }

        private void bEditDriverPhoto_Click(object sender, EventArgs e)
        {
            OpenFile(_directory);
        }

        private void bSaveDriver_Click(object sender, EventArgs e)
        {
            _dataSaver.SaveUserToXml(Driver, _directory+ "user.xml");
            UpdateUserForms(Driver);
        }

        private void bEditDriverBack_Click(object sender, EventArgs e)
        {
            panelStart.BringToFront();
        }

        private void bAddExpense_Click(object sender, EventArgs e)
        {
            panelNewExpense.BringToFront();
            foreach (var car in Driver.UserCars)
            {
                cbSelectCarsExpense.Items.Add(string.Format("{0}, {1}, {2},{3}",car.Brand,car.Model,car.ProductionDate.Year, car.Vin));
            }
            foreach (var item in Enum.GetNames(typeof(ExpenseTypes)))
            {
                cbExpenseType.Items.Add(item);
            }
        }

        private void bCreateExpense_Click(object sender, EventArgs e)
        {
            var expenseCreator = new ExpenseCreator(this);
            expenseCreator.CreateExpense(cbSelectCarsExpense.Text, cbExpenseType.Text, tbExpenseCost.Text,
                                        tbExpenseDescription.Text, tbAdditionalInfo.Text);
        }
    }
}
