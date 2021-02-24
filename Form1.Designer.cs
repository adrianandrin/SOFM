
namespace SOFM
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
            this.button1 = new System.Windows.Forms.Button();
            this.imageMagnifier1 = new ImageMagnifier.ImageMagnifier();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetGrid = new System.Windows.Forms.Button();
            this.initializeGrid = new System.Windows.Forms.Button();
            this.numOfLines = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BPM = new System.Windows.Forms.Label();
            this.dancabilityPanel = new System.Windows.Forms.Panel();
            this.energyPanel = new System.Windows.Forms.Panel();
            this.genrePanel = new System.Windows.Forms.Panel();
            this.bpmPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetGrid);
            this.groupBox1.Controls.Add(this.initializeGrid);
            this.groupBox1.Controls.Add(this.numOfLines);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // resetGrid
            // 
            this.resetGrid.Enabled = false;
            this.resetGrid.Location = new System.Drawing.Point(163, 49);
            this.resetGrid.Name = "resetGrid";
            this.resetGrid.Size = new System.Drawing.Size(75, 23);
            this.resetGrid.TabIndex = 2;
            this.resetGrid.Text = "Reset Grid";
            this.resetGrid.UseVisualStyleBackColor = true;
            this.resetGrid.Click += new System.EventHandler(this.resetGrid_Click);
            // 
            // initializeGrid
            // 
            this.initializeGrid.Location = new System.Drawing.Point(67, 49);
            this.initializeGrid.Name = "initializeGrid";
            this.initializeGrid.Size = new System.Drawing.Size(90, 23);
            this.initializeGrid.TabIndex = 1;
            this.initializeGrid.Text = "Initialize Grid";
            this.initializeGrid.UseVisualStyleBackColor = true;
            this.initializeGrid.Click += new System.EventHandler(this.initializeGrid_Click);
            // 
            // numOfLines
            // 
            this.numOfLines.Location = new System.Drawing.Point(6, 49);
            this.numOfLines.Name = "numOfLines";
            this.numOfLines.Size = new System.Drawing.Size(55, 20);
            this.numOfLines.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BPM);
            this.groupBox2.Controls.Add(this.dancabilityPanel);
            this.groupBox2.Controls.Add(this.energyPanel);
            this.groupBox2.Controls.Add(this.genrePanel);
            this.groupBox2.Controls.Add(this.bpmPanel);
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 854);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cluster";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "DANCABILITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "GENRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENERGY";
            // 
            // BPM
            // 
            this.BPM.AutoSize = true;
            this.BPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPM.Location = new System.Drawing.Point(177, 16);
            this.BPM.Name = "BPM";
            this.BPM.Size = new System.Drawing.Size(53, 24);
            this.BPM.TabIndex = 3;
            this.BPM.Text = "BPM";
            // 
            // dancabilityPanel
            // 
            this.dancabilityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dancabilityPanel.Location = new System.Drawing.Point(473, 466);
            this.dancabilityPanel.Name = "dancabilityPanel";
            this.dancabilityPanel.Size = new System.Drawing.Size(401, 382);
            this.dancabilityPanel.TabIndex = 2;
            // 
            // energyPanel
            // 
            this.energyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.energyPanel.Location = new System.Drawing.Point(17, 466);
            this.energyPanel.Name = "energyPanel";
            this.energyPanel.Size = new System.Drawing.Size(401, 382);
            this.energyPanel.TabIndex = 1;
            // 
            // genrePanel
            // 
            this.genrePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genrePanel.Location = new System.Drawing.Point(473, 43);
            this.genrePanel.Name = "genrePanel";
            this.genrePanel.Size = new System.Drawing.Size(401, 382);
            this.genrePanel.TabIndex = 1;
            // 
            // bpmPanel
            // 
            this.bpmPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bpmPanel.Location = new System.Drawing.Point(17, 43);
            this.bpmPanel.Name = "bpmPanel";
            this.bpmPanel.Size = new System.Drawing.Size(401, 382);
            this.bpmPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private ImageMagnifier.ImageMagnifier imageMagnifier1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetGrid;
        private System.Windows.Forms.Button initializeGrid;
        private System.Windows.Forms.TextBox numOfLines;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BPM;
        private System.Windows.Forms.Panel dancabilityPanel;
        private System.Windows.Forms.Panel energyPanel;
        private System.Windows.Forms.Panel genrePanel;
        private System.Windows.Forms.Panel bpmPanel;
    }
}

