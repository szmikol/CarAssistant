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

namespace CarAssistant
{
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
        }

        private void bDriverPhoto_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            string path = @"c:\CarAssistant\user.jpg";
            try
            {
                OpenFileDialog loadUserImage = new OpenFileDialog();
                loadUserImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                if (loadUserImage.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = loadUserImage.FileName;
                    Directory.CreateDirectory(@"c:\CarAssistant");
                    File.Copy(imageLocation, path, true);
                    
                    pbUserImageLoad.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("Wrong file path.", "error", MessageBoxButtons.OK);
            }
        }
    }
}
