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

namespace CarAssistant
{
	public partial class Form1 : Form
	{
        
		public Form1()
		{
			InitializeComponent();
		}


        private void bExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void bCars_Click(object sender, EventArgs e)
        {
            panelCars.BringToFront();
        }

        private void bManage_Click(object sender, EventArgs e)
        {
            panelManage.BringToFront();
        }

        private void bService_Click(object sender, EventArgs e)
        {
            panelService.BringToFront();
        }

        private void bInsurance_Click(object sender, EventArgs e)
        {
            panelInsurance.BringToFront();
        }

        private void bRefuel_Click(object sender, EventArgs e)
        {
            panelRefuel.BringToFront();
        }

        private void bExpenses_Click(object sender, EventArgs e)
        {
            panelExpenses.BringToFront();
        }

        private void bReminders_Click(object sender, EventArgs e)
        {
            panelReminders.BringToFront();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            panelSettings.BringToFront();
        }
        private void bSaveLoad_Click(object sender, EventArgs e)
        {
            panelSaveLoad.BringToFront();
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

    }
}
