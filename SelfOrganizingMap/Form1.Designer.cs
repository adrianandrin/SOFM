
namespace SelfOrganizingMap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dancabilityVisualization = new SelfOrganizingMap.Properties.Visualization();
            this.energyVisualization = new SelfOrganizingMap.Properties.Visualization();
            this.genreVisualization = new SelfOrganizingMap.Properties.Visualization();
            this.bpmVisualization = new SelfOrganizingMap.Properties.Visualization();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(429, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Input";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dancabilityVisualization);
            this.groupBox2.Controls.Add(this.energyVisualization);
            this.groupBox2.Controls.Add(this.genreVisualization);
            this.groupBox2.Controls.Add(this.bpmVisualization);
            this.groupBox2.Location = new System.Drawing.Point(469, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1001, 908);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kohonen map";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(1488, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 864);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(668, 469);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "DANCABILITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "ENERGY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "GENRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "BPM";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(16, 446);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(429, 465);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Prediction";
            // 
            // dancabilityVisualization
            // 
            this.dancabilityVisualization.Location = new System.Drawing.Point(524, 502);
            this.dancabilityVisualization.Margin = new System.Windows.Forms.Padding(4);
            this.dancabilityVisualization.Matrix = null;
            this.dancabilityVisualization.Name = "dancabilityVisualization";
            this.dancabilityVisualization.Size = new System.Drawing.Size(441, 394);
            this.dancabilityVisualization.TabIndex = 3;
            this.dancabilityVisualization.Text = "visualization3";
            this.dancabilityVisualization.ZoomFactor = 1;
            // 
            // energyVisualization
            // 
            this.energyVisualization.Location = new System.Drawing.Point(47, 502);
            this.energyVisualization.Margin = new System.Windows.Forms.Padding(4);
            this.energyVisualization.Matrix = null;
            this.energyVisualization.Name = "energyVisualization";
            this.energyVisualization.Size = new System.Drawing.Size(441, 394);
            this.energyVisualization.TabIndex = 2;
            this.energyVisualization.Text = "visualization4";
            this.energyVisualization.ZoomFactor = 1;
            // 
            // genreVisualization
            // 
            this.genreVisualization.Location = new System.Drawing.Point(524, 48);
            this.genreVisualization.Margin = new System.Windows.Forms.Padding(4);
            this.genreVisualization.Matrix = null;
            this.genreVisualization.Name = "genreVisualization";
            this.genreVisualization.Size = new System.Drawing.Size(441, 394);
            this.genreVisualization.TabIndex = 1;
            this.genreVisualization.Text = "visualization2";
            this.genreVisualization.ZoomFactor = 1;
            // 
            // bpmVisualization
            // 
            this.bpmVisualization.Location = new System.Drawing.Point(47, 48);
            this.bpmVisualization.Margin = new System.Windows.Forms.Padding(4);
            this.bpmVisualization.Matrix = null;
            this.bpmVisualization.Name = "bpmVisualization";
            this.bpmVisualization.Size = new System.Drawing.Size(441, 394);
            this.bpmVisualization.TabIndex = 0;
            this.bpmVisualization.Text = "visualization1";
            this.bpmVisualization.ZoomFactor = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 937);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Properties.Visualization dancabilityVisualization;
        private Properties.Visualization energyVisualization;
        private Properties.Visualization genreVisualization;
        private Properties.Visualization bpmVisualization;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

