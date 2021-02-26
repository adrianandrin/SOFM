using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOFM;
namespace SelfOrganizingMap
{
    public partial class Form1 : Form
    {

        private int length;
        private string path;
        private Functions act;

        private NeuralNetwork n;
        public Form1()
        {
            InitializeComponent();
            dropDown();
            setActivation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dropDown();
            setActivation();
            n = new NeuralNetwork((int)Math.Sqrt(100), 10, 0.1, act);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
  
            n.ReadDataFromFile(path);
            bcVisualization.Matrix = null;
            n.Normalize = true;
            n.StartLearning();


            System.Drawing.Color[,] colorMatrix = null;
            colorMatrix = n.ColorSOFM();
            bcVisualization.Matrix = colorMatrix;

            bcVisualization.Invalidate();
            AddLegend();
            n.Normalize = true;
            length = n.Patterns.Count;
           
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            dropDown();
            setActivation();
            string sourceFile = "", destinationFile = @"D:\Adrian-Andrin\Documents\School\Intelligent System 2\SOFM\SelfOrganizingMap\sampletest.txt";
            if (path != null)
            {
                try
                {
                    File.Copy(path, destinationFile, true);
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
                }
                path = destinationFile;

                string testfile = "";
                MessageBox.Show("Load Test Data");
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog1.Title = "Load Test Data";
                    testfile = openFileDialog1.FileName;
                }
                string contents = File.ReadAllText(testfile);
                File.AppendAllText(path, contents + "Un-Identified");
                n.ExistentClasses.Clear();
                n = new NeuralNetwork((int)Math.Sqrt(100), 10, 0.1, act);
             
                n.ReadDataFromFile(path);

                bcVisualization.Matrix = null;
                n.Normalize = true;
                n.StartLearning();
                System.Drawing.Color[,] colorMatrix = null;
                colorMatrix = n.ColorSOFM();

               
                bcVisualization.Matrix = colorMatrix;

                bcVisualization.Invalidate();
                AddLegend();
                n.Normalize = true;
                length = n.Patterns.Count;
                
                //File.Delete(destinationFile);
            }
            else
            {
                MessageBox.Show("LOAD DATA SET FIRST");
            }
          
          

        }

        private void setActivation()
        {
            if (discreteFunctionRadioButton.Checked)
            {
                act = Functions.Discrete;
            }
            else if (mexicanHatRadioButton.Checked)
            {
                act = Functions.MexicanHat;
            }
            else if (frenchHatRadioButton.Checked)
            {
                act = Functions.FrenchHat;
            }
            else if (gaussFunctionRadioButton.Checked)
            {
                act = Functions.Gaus;
            }
        }

        private void activation_Click(object sender, EventArgs e)
        {
            displaySubMenu(activationViewPanel);
            Console.WriteLine(discreteFunctionRadioButton.Checked);
            Console.WriteLine(mexicanHatRadioButton.Checked);
            Console.WriteLine(frenchHatRadioButton.Checked);
            Console.WriteLine(gaussFunctionRadioButton.Checked);
        }


        private void AddLegend()
        {
            Label label = new Label();
            label.Name = "lblLegend";
            label.Top = 5;
            label.Left = 5;
            label.Text = "Legend";
            label.AutoSize = true;
            panel1.Controls.Add(label);
            for (int i = 0; i < n.ExistentClasses.Count; i++)
            {
                Label lbl = new Label();
                lbl.Name = "lbl" + n.ExistentClasses.Keys[i];
                lbl.Text = " - " + n.ExistentClasses.Keys[i];
                lbl.Top = 20 * (i + 1);
                lbl.AutoSize = true;
                lbl.Left = 15 + (int)lbl.Font.Size;
                this.panel1.Controls.Add(lbl);

                Panel panel = new Panel();
                panel.Name = "panel" + n.ExistentClasses.Keys[i];
                panel.Top = 20 * (i + 1) + (int)lbl.Font.Size / 2;
                panel.Left = 15;
                panel.Width = (int)lbl.Font.Size;
                panel.Height = (int)lbl.Font.Size;
                panel.BackColor = n.UsedColors[i];
                this.panel1.Controls.Add(panel);
            }

            panel1.Invalidate();
        }

        private void dropDown()
        {
            activationViewPanel.Visible = false;

        }

        private void displaySubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }            
            else
            {
                subMenu.Visible = false;
            }
        }
    }
}
