using System;
using System.Windows.Forms;
using Juicy_Swapper_v2.Forms;

namespace Juicy_Swapper_v2.Classes
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            JuicyUtilities.GetStatus();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loader());
        }
    }
}
