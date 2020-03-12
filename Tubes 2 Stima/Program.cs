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
        public static Microsoft.Msagl.Drawing.Graph copyGraphMsagl(Microsoft.Msagl.Drawing.Graph graph)
        {
            Microsoft.Msagl.Drawing.Graph res = new Microsoft.Msagl.Drawing.Graph("graph");
            foreach (var edge in graph.Edges)
            {
                res.AddEdge(edge.Source, edge.Target).Attr.Color = edge.Attr.Color;
                res.FindNode(edge.Source).Attr.Color = graph.FindNode(edge.Source).Attr.Color;
                res.FindNode(edge.Target).Attr.Color = graph.FindNode(edge.Target).Attr.Color;
            }
            return res;
        }
        //public static List<Tuple<Tuple<string, string>, int>> listInfected;
    }
}
