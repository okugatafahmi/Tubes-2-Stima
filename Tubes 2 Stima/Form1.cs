using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_2_Stima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowseFileConnection_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxCityConnectionFile.Text = openFileDialog1.FileName;
                textBoxCityConnectionFile.SelectionStart = textBoxCityConnectionFile.Text.Length;
            }
        }

        private void buttonBrowseFilePopulation_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxCityPopulationFile.Text = openFileDialog1.FileName;
                textBoxCityPopulationFile.SelectionStart = textBoxCityConnectionFile.Text.Length;
            }
        }

        private void buttonCreateGraph_Click(object sender, EventArgs e)
        {
            if (textBoxCityConnectionFile.Text != "" && textBoxCityPopulationFile.Text != "")
            {
                Program.graph.ReadFromFile(textBoxCityConnectionFile.Text, textBoxCityPopulationFile.Text);
                System.Windows.Forms.Form form = new System.Windows.Forms.Form();
                Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
                foreach (KeyValuePair<string, City> keyValue in Program.graph.CityDict)
                {
                    foreach(Tuple<string, double> tuple in keyValue.Value.Adj)
                    {
                        graph.AddEdge(keyValue.Key, tuple.Item1);
                    }
                }
                viewer.Graph = graph;
                form.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                form.Controls.Add(viewer);
                form.ResumeLayout();
                //show the form 
                form.ShowDialog();
                this.groupBoxTraverseCities.Visible = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Program.listInfected = Program.graph.BFS((int)numericUpDownTimeTotal.Value);
            foreach(var item in Program.listInfected)
            {
                Console.WriteLine(item.Item1.Item1 + " " + item.Item1.Item2 + " " + item.Item2);
            }
        }
    }
}
