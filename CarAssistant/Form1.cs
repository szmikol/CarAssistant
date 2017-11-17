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
            bool exit = false;
            exit = ButtonsBehavior.ExitYesNo(exit);
            if (exit) { Close(); };
        }

        private void bCars_Click(object sender, EventArgs e)
        {
            panelCars.BringToFront();
        }

        private void bManage_Click(object sender, EventArgs e)
        {
            panelManage.BringToFront();
        }
    }
}
