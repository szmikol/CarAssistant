using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarAssistant.Classes.Facade
{
    public class ButtonsBehavior
    {
        private static DialogResult dialogResult;

        public static bool ExitYesNo(bool exit)
        {
            dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                exit = true;
            }
            return exit;
        }
        public void FocusColorCheck()
        {

        }
    }
}
