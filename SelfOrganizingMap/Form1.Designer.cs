
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.predictButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.activationViewPanel = new System.Windows.Forms.Panel();
            this.frenchHatRadioButton = new System.Windows.Forms.RadioButton();
            this.mexicanHatRadioButton = new System.Windows.Forms.RadioButton();
            this.gaussFunctionRadioButton = new System.Windows.Forms.RadioButton();
            this.discreteFunctionRadioButton = new System.Windows.Forms.RadioButton();
            this.activation = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bcVisualization = new SelfOrganizingMap.Properties.Visualization();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarPanel.SuspendLayout();
            this.activationViewPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(241, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Data Set";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(904, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 108);
            this.panel1.TabIndex = 7;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.AutoScroll = true;
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(134)))), ((int)(((byte)(66)))));
            this.sidebarPanel.Controls.Add(this.predictButton);
            this.sidebarPanel.Controls.Add(this.saveDataButton);
            this.sidebarPanel.Controls.Add(this.activationViewPanel);
            this.sidebarPanel.Controls.Add(this.activation);
            this.sidebarPanel.Controls.Add(this.button1);
            this.sidebarPanel.Controls.Add(this.panel3);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(241, 656);
            this.sidebarPanel.TabIndex = 8;
            // 
            // predictButton
            // 
            this.predictButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.predictButton.FlatAppearance.BorderSize = 0;
            this.predictButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.predictButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.predictButton.Location = new System.Drawing.Point(0, 446);
            this.predictButton.Name = "predictButton";
            this.predictButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.predictButton.Size = new System.Drawing.Size(241, 51);
            this.predictButton.TabIndex = 4;
            this.predictButton.Text = "Predict";
            this.predictButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.predictButton.UseVisualStyleBackColor = true;
            // 
            // saveDataButton
            // 
            this.saveDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveDataButton.FlatAppearance.BorderSize = 0;
            this.saveDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveDataButton.Location = new System.Drawing.Point(0, 395);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.saveDataButton.Size = new System.Drawing.Size(241, 51);
            this.saveDataButton.TabIndex = 3;
            this.saveDataButton.Text = "Save Data Set";
            this.saveDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveDataButton.UseVisualStyleBackColor = true;
            // 
            // activationViewPanel
            // 
            this.activationViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(172)))), ((int)(((byte)(105)))));
            this.activationViewPanel.Controls.Add(this.frenchHatRadioButton);
            this.activationViewPanel.Controls.Add(this.mexicanHatRadioButton);
            this.activationViewPanel.Controls.Add(this.gaussFunctionRadioButton);
            this.activationViewPanel.Controls.Add(this.discreteFunctionRadioButton);
            this.activationViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.activationViewPanel.Location = new System.Drawing.Point(0, 252);
            this.activationViewPanel.Name = "activationViewPanel";
            this.activationViewPanel.Size = new System.Drawing.Size(241, 143);
            this.activationViewPanel.TabIndex = 2;
            // 
            // frenchHatRadioButton
            // 
            this.frenchHatRadioButton.AutoSize = true;
            this.frenchHatRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.frenchHatRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frenchHatRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchHatRadioButton.ForeColor = System.Drawing.Color.White;
            this.frenchHatRadioButton.Location = new System.Drawing.Point(0, 99);
            this.frenchHatRadioButton.Name = "frenchHatRadioButton";
            this.frenchHatRadioButton.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.frenchHatRadioButton.Size = new System.Drawing.Size(241, 33);
            this.frenchHatRadioButton.TabIndex = 3;
            this.frenchHatRadioButton.Text = "French Hat ";
            this.frenchHatRadioButton.UseVisualStyleBackColor = true;
            // 
            // mexicanHatRadioButton
            // 
            this.mexicanHatRadioButton.AutoSize = true;
            this.mexicanHatRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mexicanHatRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mexicanHatRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mexicanHatRadioButton.ForeColor = System.Drawing.Color.White;
            this.mexicanHatRadioButton.Location = new System.Drawing.Point(0, 66);
            this.mexicanHatRadioButton.Name = "mexicanHatRadioButton";
            this.mexicanHatRadioButton.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.mexicanHatRadioButton.Size = new System.Drawing.Size(241, 33);
            this.mexicanHatRadioButton.TabIndex = 2;
            this.mexicanHatRadioButton.Text = "Mexican Hat";
            this.mexicanHatRadioButton.UseVisualStyleBackColor = true;
            // 
            // gaussFunctionRadioButton
            // 
            this.gaussFunctionRadioButton.AutoSize = true;
            this.gaussFunctionRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.gaussFunctionRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gaussFunctionRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaussFunctionRadioButton.ForeColor = System.Drawing.Color.White;
            this.gaussFunctionRadioButton.Location = new System.Drawing.Point(0, 33);
            this.gaussFunctionRadioButton.Name = "gaussFunctionRadioButton";
            this.gaussFunctionRadioButton.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.gaussFunctionRadioButton.Size = new System.Drawing.Size(241, 33);
            this.gaussFunctionRadioButton.TabIndex = 1;
            this.gaussFunctionRadioButton.Text = "Gauss Function";
            this.gaussFunctionRadioButton.UseVisualStyleBackColor = true;
            // 
            // discreteFunctionRadioButton
            // 
            this.discreteFunctionRadioButton.AutoSize = true;
            this.discreteFunctionRadioButton.Checked = true;
            this.discreteFunctionRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.discreteFunctionRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discreteFunctionRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discreteFunctionRadioButton.ForeColor = System.Drawing.Color.White;
            this.discreteFunctionRadioButton.Location = new System.Drawing.Point(0, 0);
            this.discreteFunctionRadioButton.Name = "discreteFunctionRadioButton";
            this.discreteFunctionRadioButton.Padding = new System.Windows.Forms.Padding(20, 2, 0, 2);
            this.discreteFunctionRadioButton.Size = new System.Drawing.Size(241, 33);
            this.discreteFunctionRadioButton.TabIndex = 0;
            this.discreteFunctionRadioButton.TabStop = true;
            this.discreteFunctionRadioButton.Text = "Discrete Function";
            this.discreteFunctionRadioButton.UseVisualStyleBackColor = true;
            // 
            // activation
            // 
            this.activation.Dock = System.Windows.Forms.DockStyle.Top;
            this.activation.FlatAppearance.BorderSize = 0;
            this.activation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activation.Location = new System.Drawing.Point(0, 201);
            this.activation.Name = "activation";
            this.activation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.activation.Size = new System.Drawing.Size(241, 51);
            this.activation.TabIndex = 1;
            this.activation.Text = "Activation";
            this.activation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activation.UseVisualStyleBackColor = true;
            this.activation.Click += new System.EventHandler(this.activation_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(172)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 150);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breast Cancer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 65);
            this.label4.TabIndex = 2;
            this.label4.Text = "MAP";
            // 
            // bcVisualization
            // 
            this.bcVisualization.Location = new System.Drawing.Point(270, 16);
            this.bcVisualization.Matrix = null;
            this.bcVisualization.Name = "bcVisualization";
            this.bcVisualization.Size = new System.Drawing.Size(615, 615);
            this.bcVisualization.TabIndex = 0;
            this.bcVisualization.Text = "visualization1";
            this.bcVisualization.ZoomFactor = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "KOHONEN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1027, 656);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.bcVisualization);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sidebarPanel.ResumeLayout(false);
            this.activationViewPanel.ResumeLayout(false);
            this.activationViewPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Properties.Visualization bcVisualization;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel activationViewPanel;
        private System.Windows.Forms.RadioButton frenchHatRadioButton;
        private System.Windows.Forms.RadioButton mexicanHatRadioButton;
        private System.Windows.Forms.RadioButton gaussFunctionRadioButton;
        private System.Windows.Forms.RadioButton discreteFunctionRadioButton;
        private System.Windows.Forms.Button activation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button predictButton;
        private System.Windows.Forms.Label label1;
    }
}

