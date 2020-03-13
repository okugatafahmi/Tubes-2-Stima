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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.numericUpDownJumpTo = new System.Windows.Forms.NumericUpDown();
            this.labelJumpTo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBoxInputFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeTotal)).BeginInit();
            this.groupBoxTraverseCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.groupBoxInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInputFile.ForeColor = System.Drawing.Color.White;
            this.groupBoxInputFile.Location = new System.Drawing.Point(22, 104);
            this.groupBoxInputFile.Name = "groupBoxInputFile";
            this.groupBoxInputFile.Size = new System.Drawing.Size(360, 217);
            this.groupBoxInputFile.TabIndex = 0;
            this.groupBoxInputFile.TabStop = false;
            this.groupBoxInputFile.Text = "Input File";
            // 
            // buttonCreateGraph
            // 
            this.buttonCreateGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(181)))), ((int)(((byte)(77)))));
            this.buttonCreateGraph.FlatAppearance.BorderSize = 0;
            this.buttonCreateGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonCreateGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.buttonCreateGraph.Location = new System.Drawing.Point(117, 174);
            this.buttonCreateGraph.Name = "buttonCreateGraph";
            this.buttonCreateGraph.Size = new System.Drawing.Size(101, 32);
            this.buttonCreateGraph.TabIndex = 7;
            this.buttonCreateGraph.Text = "Create Graph";
            this.buttonCreateGraph.UseVisualStyleBackColor = false;
            this.buttonCreateGraph.Click += new System.EventHandler(this.buttonCreateGraph_Click);
            // 
            // buttonBrowseFilePopulation
            // 
            this.buttonBrowseFilePopulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(181)))), ((int)(((byte)(77)))));
            this.buttonBrowseFilePopulation.FlatAppearance.BorderSize = 0;
            this.buttonBrowseFilePopulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseFilePopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonBrowseFilePopulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.buttonBrowseFilePopulation.Location = new System.Drawing.Point(224, 128);
            this.buttonBrowseFilePopulation.Name = "buttonBrowseFilePopulation";
            this.buttonBrowseFilePopulation.Size = new System.Drawing.Size(87, 23);
            this.buttonBrowseFilePopulation.TabIndex = 6;
            this.buttonBrowseFilePopulation.Text = "Browse File";
            this.buttonBrowseFilePopulation.UseVisualStyleBackColor = false;
            this.buttonBrowseFilePopulation.Click += new System.EventHandler(this.buttonBrowseFilePopulation_Click);
            // 
            // buttonBrowseFileConnection
            // 
            this.buttonBrowseFileConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(181)))), ((int)(((byte)(77)))));
            this.buttonBrowseFileConnection.FlatAppearance.BorderSize = 0;
            this.buttonBrowseFileConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseFileConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonBrowseFileConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.buttonBrowseFileConnection.Location = new System.Drawing.Point(224, 61);
            this.buttonBrowseFileConnection.Name = "buttonBrowseFileConnection";
            this.buttonBrowseFileConnection.Size = new System.Drawing.Size(87, 23);
            this.buttonBrowseFileConnection.TabIndex = 5;
            this.buttonBrowseFileConnection.Text = "Browse File";
            this.buttonBrowseFileConnection.UseVisualStyleBackColor = false;
            this.buttonBrowseFileConnection.Click += new System.EventHandler(this.buttonBrowseFileConnection_Click);
            // 
            // textBoxCityPopulationFile
            // 
            this.textBoxCityPopulationFile.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCityPopulationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCityPopulationFile.Location = new System.Drawing.Point(30, 128);
            this.textBoxCityPopulationFile.Name = "textBoxCityPopulationFile";
            this.textBoxCityPopulationFile.ReadOnly = true;
            this.textBoxCityPopulationFile.Size = new System.Drawing.Size(188, 23);
            this.textBoxCityPopulationFile.TabIndex = 3;
            // 
            // labelCityPopulation
            // 
            this.labelCityPopulation.AutoSize = true;
            this.labelCityPopulation.BackColor = System.Drawing.Color.Transparent;
            this.labelCityPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCityPopulation.Location = new System.Drawing.Point(27, 109);
            this.labelCityPopulation.Name = "labelCityPopulation";
            this.labelCityPopulation.Size = new System.Drawing.Size(102, 17);
            this.labelCityPopulation.TabIndex = 4;
            this.labelCityPopulation.Text = "City Population";
            // 
            // textBoxCityConnectionFile
            // 
            this.textBoxCityConnectionFile.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCityConnectionFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCityConnectionFile.Location = new System.Drawing.Point(30, 61);
            this.textBoxCityConnectionFile.Name = "textBoxCityConnectionFile";
            this.textBoxCityConnectionFile.ReadOnly = true;
            this.textBoxCityConnectionFile.Size = new System.Drawing.Size(188, 23);
            this.textBoxCityConnectionFile.TabIndex = 2;
            // 
            // labelCityConnection
            // 
            this.labelCityConnection.AutoSize = true;
            this.labelCityConnection.BackColor = System.Drawing.Color.Transparent;
            this.labelCityConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCityConnection.Location = new System.Drawing.Point(27, 42);
            this.labelCityConnection.Name = "labelCityConnection";
            this.labelCityConnection.Size = new System.Drawing.Size(106, 17);
            this.labelCityConnection.TabIndex = 2;
            this.labelCityConnection.Text = "City Connection";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(181)))), ((int)(((byte)(77)))));
            this.labelTitle.Location = new System.Drawing.Point(115, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(148, 31);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "COVID-19";
            // 
            // numericUpDownTimeTotal
            // 
            this.numericUpDownTimeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numericUpDownTimeTotal.Location = new System.Drawing.Point(117, 33);
            this.numericUpDownTimeTotal.Name = "numericUpDownTimeTotal";
            this.numericUpDownTimeTotal.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownTimeTotal.TabIndex = 3;
            // 
            // labelTimeTotal
            // 
            this.labelTimeTotal.AutoSize = true;
            this.labelTimeTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTimeTotal.Location = new System.Drawing.Point(27, 33);
            this.labelTimeTotal.Name = "labelTimeTotal";
            this.labelTimeTotal.Size = new System.Drawing.Size(75, 17);
            this.labelTimeTotal.TabIndex = 4;
            this.labelTimeTotal.Text = "Time Total";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(181)))), ((int)(((byte)(77)))));
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(68)))));
            this.buttonStart.Location = new System.Drawing.Point(117, 76);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(101, 27);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxTraverseCities
            // 
            this.groupBoxTraverseCities.Controls.Add(this.numericUpDownTimeTotal);
            this.groupBoxTraverseCities.Controls.Add(this.labelTimeTotal);
            this.groupBoxTraverseCities.Controls.Add(this.buttonStart);
            this.groupBoxTraverseCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBoxTraverseCities.ForeColor = System.Drawing.Color.White;
            this.groupBoxTraverseCities.Location = new System.Drawing.Point(22, 350);
            this.groupBoxTraverseCities.Name = "groupBoxTraverseCities";
            this.groupBoxTraverseCities.Size = new System.Drawing.Size(360, 109);
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
            this.gViewer.BackColor = System.Drawing.SystemColors.Window;
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
            this.gViewer.Location = new System.Drawing.Point(432, 47);
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
            this.gViewer.Size = new System.Drawing.Size(463, 412);
            this.gViewer.TabIndex = 7;
            this.gViewer.TightOffsetForRouting = 0.125D;
            this.gViewer.ToolBarIsVisible = true;
            this.gViewer.Transform = planeTransformation1;
            this.gViewer.UndoRedoButtonsVisible = true;
            this.gViewer.Visible = false;
            this.gViewer.WindowZoomButtonPressed = false;
            this.gViewer.ZoomF = 1D;
            this.gViewer.ZoomWindowThreshold = 0.05D;
            // 
            // numericUpDownJumpTo
            // 
            this.numericUpDownJumpTo.Location = new System.Drawing.Point(502, 471);
            this.numericUpDownJumpTo.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownJumpTo.Name = "numericUpDownJumpTo";
            this.numericUpDownJumpTo.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownJumpTo.TabIndex = 8;
            this.numericUpDownJumpTo.Visible = false;
            this.numericUpDownJumpTo.ValueChanged += new System.EventHandler(this.updateGraphViewer);
            // 
            // labelJumpTo
            // 
            this.labelJumpTo.AutoSize = true;
            this.labelJumpTo.BackColor = System.Drawing.Color.Transparent;
            this.labelJumpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelJumpTo.ForeColor = System.Drawing.Color.White;
            this.labelJumpTo.Location = new System.Drawing.Point(429, 474);
            this.labelJumpTo.Name = "labelJumpTo";
            this.labelJumpTo.Size = new System.Drawing.Size(58, 17);
            this.labelJumpTo.TabIndex = 9;
            this.labelJumpTo.Text = "Jump to";
            this.labelJumpTo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(893, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(869, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(845, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(920, 515);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelJumpTo);
            this.Controls.Add(this.numericUpDownJumpTo);
            this.Controls.Add(this.gViewer);
            this.Controls.Add(this.groupBoxTraverseCities);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Anti Corona";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxInputFile.ResumeLayout(false);
            this.groupBoxInputFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeTotal)).EndInit();
            this.groupBoxTraverseCities.ResumeLayout(false);
            this.groupBoxTraverseCities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownJumpTo;
        private System.Windows.Forms.Label labelJumpTo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

