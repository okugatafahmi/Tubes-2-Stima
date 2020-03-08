namespace Tubes_Stima_BFS
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxInputFile = new System.Windows.Forms.GroupBox();
            this.buttonBrowseFilePopulation = new System.Windows.Forms.Button();
            this.buttonBrowseFileConnection = new System.Windows.Forms.Button();
            this.textBoxCityPopulationFile = new System.Windows.Forms.TextBox();
            this.labelCityPopulation = new System.Windows.Forms.Label();
            this.textBoxCityConnectionFile = new System.Windows.Forms.TextBox();
            this.labelCityConnection = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonExecution = new System.Windows.Forms.Button();
            this.groupBoxInputFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text|*.txt";
            // 
            // groupBoxInputFile
            // 
            this.groupBoxInputFile.Controls.Add(this.buttonExecution);
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
            this.textBoxCityPopulationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCityPopulationFile.Location = new System.Drawing.Point(166, 145);
            this.textBoxCityPopulationFile.Name = "textBoxCityPopulationFile";
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
            this.textBoxCityConnectionFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxCityConnectionFile.Location = new System.Drawing.Point(166, 56);
            this.textBoxCityConnectionFile.Name = "textBoxCityConnectionFile";
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
            // buttonExecution
            // 
            this.buttonExecution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.buttonExecution.Location = new System.Drawing.Point(10, 221);
            this.buttonExecution.Name = "buttonExecution";
            this.buttonExecution.Size = new System.Drawing.Size(68, 27);
            this.buttonExecution.TabIndex = 7;
            this.buttonExecution.Text = "Execute";
            this.buttonExecution.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 475);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxInputFile);
            this.Name = "Form1";
            this.Text = "Anti Corona";
            this.groupBoxInputFile.ResumeLayout(false);
            this.groupBoxInputFile.PerformLayout();
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
        private System.Windows.Forms.Button buttonExecution;
    }
}

