
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bpmVisualization = new SelfOrganizingMap.Properties.Visualization();
            this.genreVisualization = new SelfOrganizingMap.Properties.Visualization();
            this.dancabilityVisualization = new SelfOrganizingMap.Properties.Visualization();
            this.energyVisualization = new SelfOrganizingMap.Properties.Visualization();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Input";
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
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 738);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kohonen map";
            // 
            // bpmVisualization
            // 
            this.bpmVisualization.Location = new System.Drawing.Point(35, 39);
            this.bpmVisualization.Matrix = null;
            this.bpmVisualization.Name = "bpmVisualization";
            this.bpmVisualization.Size = new System.Drawing.Size(331, 320);
            this.bpmVisualization.TabIndex = 0;
            this.bpmVisualization.Text = "visualization1";
            this.bpmVisualization.ZoomFactor = 1;
            // 
            // genreVisualization
            // 
            this.genreVisualization.Location = new System.Drawing.Point(393, 39);
            this.genreVisualization.Matrix = null;
            this.genreVisualization.Name = "genreVisualization";
            this.genreVisualization.Size = new System.Drawing.Size(331, 320);
            this.genreVisualization.TabIndex = 1;
            this.genreVisualization.Text = "visualization2";
            this.genreVisualization.ZoomFactor = 1;
            // 
            // dancabilityVisualization
            // 
            this.dancabilityVisualization.Location = new System.Drawing.Point(393, 408);
            this.dancabilityVisualization.Matrix = null;
            this.dancabilityVisualization.Name = "dancabilityVisualization";
            this.dancabilityVisualization.Size = new System.Drawing.Size(331, 320);
            this.dancabilityVisualization.TabIndex = 3;
            this.dancabilityVisualization.Text = "visualization3";
            this.dancabilityVisualization.ZoomFactor = 1;
            // 
            // energyVisualization
            // 
            this.energyVisualization.Location = new System.Drawing.Point(35, 408);
            this.energyVisualization.Matrix = null;
            this.energyVisualization.Name = "energyVisualization";
            this.energyVisualization.Size = new System.Drawing.Size(331, 320);
            this.energyVisualization.TabIndex = 2;
            this.energyVisualization.Text = "visualization4";
            this.energyVisualization.ZoomFactor = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "BPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "GENRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ENERGY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "DANCABILITY";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 378);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Prediction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

