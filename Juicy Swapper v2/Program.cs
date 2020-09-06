using System;
using System.Windows.Forms;
using Juicy_Swapper_v2.Classes;

namespace Juicy_Swapper_v2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //JuicyUtilities.GetStatus();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
