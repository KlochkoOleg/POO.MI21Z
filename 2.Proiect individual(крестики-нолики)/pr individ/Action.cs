using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_individ
{
     public class Act:InterfaceX
    {
        
        public int results(string s1)
        {

         DialogResult result = MessageBox.Show(
         "Game over \n Winner: " + s1+"\n Начать новую игру ?",
         "Сообщение",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Information,
         MessageBoxDefaultButton.Button1,
         MessageBoxOptions.DefaultDesktopOnly);

         if (result == DialogResult.Yes) return 23;
         else return 0;
        }

    }
}
