//Damian Grant Grobler & Albertus Petrus Louw
//POE part 2
//Vega School
//1
using System;
using System.Windows.Forms;

namespace GoblinSlayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameUI());
        }
    }
    //Test sync with master?
}
