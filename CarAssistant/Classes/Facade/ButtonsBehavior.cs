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
        private static DialogResult _dialogResult;

        public static bool ExitYesNo(bool exit)
        {
            _dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if(_dialogResult == DialogResult.Yes)
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
