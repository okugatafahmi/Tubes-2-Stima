namespace Tubes_2_Stima
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation1 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxInputFile = new System.Windows.Forms.GroupBox();
            this.buttonCreateGraph = new System.Windows.Forms.Button();
            this.buttonBrowseFilePopulation = new System.Windows.Forms.Button();
            this.buttonBrowseFileConnection = new System.Windows.Forms.Button();
            this.textBoxCityPopulationFile = new System.Windows.Forms.TextBox();
            this.labelCityPopulation = new System.Windows.Forms.Label();
            this.textBoxCityConnectionFile = new System.Windows.Forms.TextBox();
            this.labelCityConnection = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.numericUpDownTimeTotal = new System.Windows.Forms.NumericUpDown();
            this.labelTimeTotal = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxTraverseCities = new System.Windows.Forms.GroupBox();
            this.gViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.groupBoxInputFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeTotal)).BeginInit();
            this.groupBoxTraverseCities.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text|*.txt";
            // 
            // groupBoxInputFile
            // 
            this.groupBoxInputFile.Controls.Add(this.buttonCreateGraph);
            this.groupBoxInputFile.Controls.Add(this.buttonBrowseFilePopulation);
            this.groupBoxInputFile.Controls.Add(this.buttonBrowseFileConnection);
            this.groupBoxInputFile.Controls.Add(this.textBoxCityPopulationFile);
            this.groupBoxInputFile.Controls.Add(this.labelCityPopulation);
            this.groupBoxInputFile.Controls.Add(this.textBoxCityConnectionFile);
            this.groupBoxInputFile.Controls.Add(this.labelCityConnection);
            this.groupBoxInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBoxInputFile.Location = new System.Drawing.Point(22, 87);
            this.groupBoxInputFile.Name = "groupBoxInputFile";
            this.groupBoxInputFile.Size = new System.Drawing.Size(360, 264);
            this.groupBoxInputFile.TabIndex = 0;
            this.groupBoxInputFile.TabStop = false;
            this.groupBoxInputFile.Text = "Input File";
            // 
            // buttonCreateGraph
            // 
            this.buttonCreateGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonCreateGraph.Location = new System.Drawing.Point(10, 216);
            this.buttonCreateGraph.Name = "buttonCreateGraph";
            this.buttonCreateGraph.Size = new System.Drawing.Size(101, 32);
            this.buttonCreateGraph.TabIndex = 7;
            this.buttonCreateGraph.Text = "Create Graph";
            this.buttonCreateGraph.UseVisualStyleBackColor = true;
            this.buttonCreateGraph.Click += new System.EventHandler(this.buttonCreateGraph_Click);
            // 
            // buttonBrowseFilePopulation
            // 
            this.buttonBrowseFilePopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonBrowseFilePopulation.Location = new System.Drawing.Point(166, 178);
            this.buttonBrowseFilePopulation.Name = "buttonBrowseFilePopulation";
            this.buttonBrowseFilePopulation.Size = new System.Drawing.Size(87, 23);
            this.buttonBrowseFilePopulation.TabIndex = 6;
            this.buttonBrowseFilePopulation.Text = "Browse File";
            this.buttonBrowseFilePopulation.UseVisualStyleBackColor = true;
            this.buttonBrowseFilePopulation.Click += new System.EventHandler(this.buttonBrowseFilePopulation_Click);
            // 
            // buttonBrowseFileConnection
            // 
            this.buttonBrowseFileConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonBrowseFileConnection.Location = new System.Drawing.Point(166, 89);
            this.buttonBrowseFileConnection.Name = "buttonBrowseFileConnection";
            this.buttonBrowseFileConnection.Size = new System.Drawing.Size(87, 23);
            this.buttonBrowseFileConnection.TabIndex = 5;
            this.buttonBrowseFileConnection.Text = "Browse File";
            this.buttonBrowseFileConnection.UseVisualStyleBackColor = true;
            this.buttonBrowseFileConnection.Click += new System.EventHandler(this.buttonBrowseFileConnection_Click);
            // 
            // textBoxCityPopulationFile
            // 
            this.textBoxCityPopulationFile.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCityPopulationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCityPopulationFile.Location = new System.Drawing.Point(166, 145);
            this.textBoxCityPopulationFile.Name = "textBoxCityPopulationFile";
            this.textBoxCityPopulationFile.ReadOnly = true;
            this.textBoxCityPopulationFile.Size = new System.Drawing.Size(188, 23);
            this.textBoxCityPopulationFile.TabIndex = 3;
            // 
            // labelCityPopulation
            // 
            this.labelCityPopulation.AutoSize = true;
            this.labelCityPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelCityPopulation.Location = new System.Drawing.Point(6, 145);
            this.labelCityPopulation.Name = "labelCityPopulation";
            this.labelCityPopulation.Size = new System.Drawing.Size(131, 22);
            this.labelCityPopulation.TabIndex = 4;
            this.labelCityPopulation.Text = "City Population";
            // 
            // textBoxCityConnectionFile
            // 
            this.textBoxCityConnectionFile.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCityConnectionFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCityConnectionFile.Location = new System.Drawing.Point(166, 56);
            this.textBoxCityConnectionFile.Name = "textBoxCityConnectionFile";
            this.textBoxCityConnectionFile.ReadOnly = true;
            this.textBoxCityConnectionFile.Size = new System.Drawing.Size(188, 23);
            this.textBoxCityConnectionFile.TabIndex = 2;
            // 
            // labelCityConnection
            // 
            this.labelCityConnection.AutoSize = true;
            this.labelCityConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelCityConnection.Location = new System.Drawing.Point(6, 56);
            this.labelCityConnection.Name = "labelCityConnection";
            this.labelCityConnection.Size = new System.Drawing.Size(137, 22);
            this.labelCityConnection.TabIndex = 2;
            this.labelCityConnection.Text = "City Connection";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelTitle.Location = new System.Drawing.Point(16, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(163, 31);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Corona BFS";
            // 
            // numericUpDownTimeTotal
            // 
            this.numericUpDownTimeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numericUpDownTimeTotal.Location = new System.Drawing.Point(141, 33);
            this.numericUpDownTimeTotal.Name = "numericUpDownTimeTotal";
            this.numericUpDownTimeTotal.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownTimeTotal.TabIndex = 3;
            // 
            // labelTimeTotal
            // 
            this.labelTimeTotal.AutoSize = true;
            this.labelTimeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelTimeTotal.Location = new System.Drawing.Point(6, 32);
            this.labelTimeTotal.Name = "labelTimeTotal";
            this.labelTimeTotal.Size = new System.Drawing.Size(96, 22);
            this.labelTimeTotal.TabIndex = 4;
            this.labelTimeTotal.Text = "Time Total";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(10, 71);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxTraverseCities
            // 
            this.groupBoxTraverseCities.Controls.Add(this.numericUpDownTimeTotal);
            this.groupBoxTraverseCities.Controls.Add(this.labelTimeTotal);
            this.groupBoxTraverseCities.Controls.Add(this.buttonStart);
            this.groupBoxTraverseCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBoxTraverseCities.Location = new System.Drawing.Point(22, 371);
            this.groupBoxTraverseCities.Name = "groupBoxTraverseCities";
            this.groupBoxTraverseCities.Size = new System.Drawing.Size(206, 114);
            this.groupBoxTraverseCities.TabIndex = 6;
            this.groupBoxTraverseCities.TabStop = false;
            this.groupBoxTraverseCities.Text = "Traverse Cities";
            this.groupBoxTraverseCities.Visible = false;
            // 
            // gViewer
            // 
            this.gViewer.ArrowheadLength = 10D;
            this.gViewer.AsyncLayout = false;
            this.gViewer.AutoScroll = true;
            this.gViewer.BackwardEnabled = false;
            this.gViewer.BuildHitTree = true;
            this.gViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer.EdgeInsertButtonVisible = true;
            this.gViewer.FileName = "";
            this.gViewer.ForwardEnabled = false;
            this.gViewer.Graph = null;
            this.gViewer.InsertingEdge = false;
            this.gViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer.LayoutEditingEnabled = true;
            this.gViewer.Location = new System.Drawing.Point(432, 18);
            this.gViewer.LooseOffsetForRouting = 0.25D;
            this.gViewer.MouseHitDistance = 0.05D;
            this.gViewer.Name = "gViewer";
            this.gViewer.NavigationVisible = true;
            this.gViewer.NeedToCalculateLayout = true;
            this.gViewer.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer.PaddingForEdgeRouting = 8D;
            this.gViewer.PanButtonPressed = false;
            this.gViewer.SaveAsImageEnabled = true;
            this.gViewer.SaveAsMsaglEnabled = true;
            this.gViewer.SaveButtonVisible = true;
            this.gViewer.SaveGraphButtonVisible = true;
            this.gViewer.SaveInVectorFormatEnabled = true;
            this.gViewer.Size = new System.Drawing.Size(476, 506);
            this.gViewer.TabIndex = 7;
            this.gViewer.TightOffsetForRouting = 0.125D;
            this.gViewer.ToolBarIsVisible = true;
            this.gViewer.Transform = planeTransformation1;
            this.gViewer.UndoRedoButtonsVisible = true;
            this.gViewer.WindowZoomButtonPressed = false;
            this.gViewer.ZoomF = 1D;
            this.gViewer.ZoomWindowThreshold = 0.05D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 541);
            this.Controls.Add(this.gViewer);
            this.Controls.Add(this.groupBoxTraverseCities);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxInputFile);
            this.Name = "Form1";
            this.Text = "Anti Corona";
            this.groupBoxInputFile.ResumeLayout(false);
            this.groupBoxInputFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeTotal)).EndInit();
            this.groupBoxTraverseCities.ResumeLayout(false);
            this.groupBoxTraverseCities.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxInputFile;
        private System.Windows.Forms.TextBox textBoxCityConnectionFile;
        private System.Windows.Forms.Label labelCityConnection;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonBrowseFilePopulation;
        private System.Windows.Forms.Button buttonBrowseFileConnection;
        private System.Windows.Forms.TextBox textBoxCityPopulationFile;
        private System.Windows.Forms.Label labelCityPopulation;
        private System.Windows.Forms.Button buttonCreateGraph;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeTotal;
        private System.Windows.Forms.Label labelTimeTotal;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxTraverseCities;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer;
    }
}

