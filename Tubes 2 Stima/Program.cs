using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_2_Stima
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static CityGraph graph = new CityGraph();
        public static Microsoft.Msagl.Drawing.Graph graphPure = new Microsoft.Msagl.Drawing.Graph();
        public static List<Microsoft.Msagl.Drawing.Graph> graphMsaglList = new List<Microsoft.Msagl.Drawing.Graph>();
        //public static List<Tuple<Tuple<string, string>, int>> listInfected;
    }
}
