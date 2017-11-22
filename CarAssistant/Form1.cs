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
using System.IO;

namespace CarAssistant
{
	public partial class Form1 : Form
	{
        public User driver;
        private string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CarAssistant\\files";
        DataSaver dataSaver;
        DataLoader dataLoader;
		public Form1()
		{
			InitializeComponent();
            dataSaver = new DataSaver();
            dataLoader = new DataLoader();
            InitialDriverLoader(out driver);
            Directory.CreateDirectory(directory);
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
                System.IO.StreamReader loadStream = new System.IO.StreamReader(openFileDialog1.FileName);
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
            tbDrPIDNumber.Text = user.GetIdNumber().ToString();
            tbDrPLicenceNumber.Text = user.GetLicenceNumber().ToString();
            tbDrPOwnedCars.Text = (0 + user.userCars.Count()).ToString();
            tbDrPAddress.Text = user.GetResidenceAddress();
        }
        public void SetDriverPath(User user)
        {
            driver = user;
        }
        private void InitialDriverLoader(out User driver)
        {
            if (File.Exists(directory+"user.xml"))
            {
                LoadingImageIfExist();
                driver = dataLoader.LoadUserFromXml(directory);
                UpdateUserForms(driver);
            }
            else
            {
                driver = null;
            }
        }
        private void LoadingImageIfExist()
        {
            if (File.Exists(directory + "user.jpg"))
            {
                picUserPhoto.Image = Image.FromFile(directory +"\\user.jpg");
            }
            else
            {
                picUserPhoto.Image = Properties.Resources.BlankProfile;
            }
        }

        
    }
}
