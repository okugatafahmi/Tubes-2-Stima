using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_Stima_BFS
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
    }
}
