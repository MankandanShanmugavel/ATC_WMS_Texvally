using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedLibrary
{
    public static class Checknum
    {
        public static void AllowedCharacters(System.Windows.Forms.KeyPressEventArgs e, string AllowedChar)
        {

            // Backspace
            if (e.KeyChar == 8)
            {
            }
            else
            {
                //Enter Key
                //				if(e.KeyChar==13)
                //					SendKeys.SendWait("{TAB}");
                // Other characters
                AllowedChar = (AllowedChar);
                if (AllowedChar.IndexOf(e.KeyChar.ToString().ToUpper()) < 0)
                    e.Handled = true;
            }

        }
    }
}
