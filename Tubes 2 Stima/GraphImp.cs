using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tubes_2_Stima

class CreateGraph
{
    public static void Main()
    {
        //create a form 
        System.Windows.Forms.Form form = new System.Windows.Forms.Form();
        //create a viewer object 
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        //create a graph object 
        Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        //create the graph content
        grapphh = new CityGraph; 
        List<Tuple<string, string>> infectedcity = graphh.BFS;

        // masih akses cityDict yang di CityGraph
        // Untuk visualisasi keterhubungan antar kota dalam edge graph
        foreach (var cityy in cityDict.Values) {
            for (int i = 0; i < cityy.Adj.Count; i++)
            {
                graph.AddEdge(cityy.Name, cityy[i].Item1);
                //menambahkan warna pada edge yg mengindikasikan 2 kota yg terkena virus
                for (int j = 0; j < infectedcity.Count; j++)
				{
                    var foundTuple1 = infectedcity[j].Any(m => m.Item1 == cityy.Name);
                    var foundTuple2 = infectedcity[j].Any(m => m.Item2 == cityy[i].Item1);
                    if (foundTuple1) && (foundTuple2) {
                        graph.AddEdge(cityy.Name, cityy[i].Item1 ).Attr.Color = Microsoft.Msagl.Drawing.Color.Red; }
                }
            }
        }

        //Visualisasi warna untuk masing-masing node graph yg terinfeksi
        for (int j = 0; j < infectedcity.Count; j++)
		{
            Microsoft.Msagl.Drawing.Node infcity1 = graph.FindNode(infectedcity[j].Item1);
            infcity1.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            Microsoft.Msagl.Drawing.Node infcity2 = graph.FindNode(infectedcity[j].Item2);
            infcity2.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
        }

        //bind the graph to the viewer 
        viewer.Graph = graph;
        //associate the viewer with the form 
        form.SuspendLayout();
        viewer.Dock = System.Windows.Forms.DockStyle.Fill;
        form.Controls.Add(viewer);
        form.ResumeLayout();
        //show the form 
        form.ShowDialog();
    }
}