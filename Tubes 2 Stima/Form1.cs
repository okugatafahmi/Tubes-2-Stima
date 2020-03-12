using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using System.Runtime.InteropServices;

namespace Tubes_2_Stima
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        ( 
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
                Program.graphPure = makeGraphVisualisation();
                gViewer.Graph = Program.graphPure;
                groupBoxTraverseCities.Visible = true;
                gViewer.Visible = true;
                labelJumpTo.Visible = true;
                numericUpDownJumpTo.Visible = true;
            }
        }

        private Graph makeGraphVisualisation()
        {
            Graph graph = new Graph("graph");
            foreach (KeyValuePair<string, City> keyValue in Program.graph.CityDict)
            {
                foreach (Tuple<string, double> tuple in keyValue.Value.Adj)
                {
                    graph.AddEdge(keyValue.Key, tuple.Item1);
                }
            }
            return graph;
        }
        
        private Graph updateGraphNodeVisualisation(Graph graphBefore, string node)
        {
            Graph graph = Program.copyGraphMsagl(graphBefore);
            graph.FindNode(node).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
            return graph;
        }
        private Graph updateGraphEdgeVisualisation(Graph graphBefore, string from, string to)
        {
            Graph graph = Program.copyGraphMsagl(graphBefore);
            foreach(var edge in graph.Edges)
            {
                if (edge.Source == from && edge.Target == to)
                {
                    edge.Attr.Color = Microsoft.Msagl.Drawing.Color.DarkRed;
                    graph.FindNode(to).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    break;
                }
            }
            return graph;
        }

        private void updateGraphViewer(Object sender, EventArgs e)
        {
            gViewer.Graph = Program.graphMsaglList[(int)numericUpDownJumpTo.Value];
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            List<Tuple<Tuple<string, string>, int>> listInfected = Program.graph.BFS((int)numericUpDownTimeTotal.Value);
            listInfected.Sort((item1, item2) => item1.Item2.CompareTo(item2.Item2));

            if (Program.graphMsaglList.Count != 0) Program.graphMsaglList.Clear();

            Graph graph = updateGraphNodeVisualisation(Program.graphPure, Program.graph.StartNode);
            for (int i=0, idx=0; i<=(int)numericUpDownTimeTotal.Value; ++i)
            {
                if (idx < listInfected.Count)
                {
                    while(listInfected[idx].Item2==i && idx < listInfected.Count-1)
                    {
                        Console.WriteLine(listInfected[idx].Item1.Item1 + " " + listInfected[idx].Item1.Item2 + " " + listInfected[idx].Item2);
                        graph = updateGraphEdgeVisualisation(graph, listInfected[idx].Item1.Item1, listInfected[idx].Item1.Item2);
                        ++idx;
                    }
                    if (listInfected[idx].Item2 == i)
                    {
                        Console.WriteLine(listInfected[idx].Item1.Item1 + " " + listInfected[idx].Item1.Item2 + " " + listInfected[idx].Item2);
                        graph = updateGraphEdgeVisualisation(graph, listInfected[idx].Item1.Item1, listInfected[idx].Item1.Item2);
                        ++idx;
                    }
                }
                
                Program.graphMsaglList.Add(graph);
            }
            decimal valBefore = numericUpDownJumpTo.Value;
            if (numericUpDownJumpTo.Maximum < numericUpDownTimeTotal.Value)
            {
                numericUpDownJumpTo.Maximum = numericUpDownTimeTotal.Value;
                numericUpDownJumpTo.Value = numericUpDownTimeTotal.Value;
            }
            else
            {
                numericUpDownJumpTo.Value = numericUpDownTimeTotal.Value;
                numericUpDownJumpTo.Maximum = numericUpDownTimeTotal.Value;
            }

            if (valBefore == numericUpDownJumpTo.Value)
            {
                gViewer.Graph = Program.graphMsaglList[(int)valBefore];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxInputFile.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
            groupBoxTraverseCities.BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else 
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
