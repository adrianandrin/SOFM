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
        private Point[,] bpm, energy, genre, dancability;
        private SOFM.NeuralNetwork nn;
        private List<string[]> songs;
        private List<string[]> genres;
        private Neuron winners;
        private float xSpace, ySpace;
        private int lines;
        private int length;
        private string path;

        private NeuralNetwork n;
        public Form1()
        {
            InitializeComponent();
            dropDown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var path = @"C:\Users\maxim\Desktop\Class stuff\Third Year First Sem C1\Intelligent Systems 2\My Activities\top10spotify\top10s.csv"; // Habeeb, "Dubai Media City, Dubai"
            // var path2 = @"C:\Users\maxim\Desktop\Class stuff\Third Year First Sem C1\Intelligent Systems 2\My Activities\top10spotify\genres.csv"; // Habeeb, "Dubai Media City, Dubai"
            
            n = new NeuralNetwork((int)Math.Sqrt(1000), 10, 0.1, Functions.MexicanHat);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
           // Habeeb, "Dubai Media City, Dubai"
            Console.WriteLine(path);
            n.ReadDataFromFile(path);
            //bpmVisualization
            bcVisualization.Matrix = null;
            n.Normalize = true;
            n.StartLearning();
            Console.WriteLine(n.Patterns.Count);
            Console.WriteLine("RE");
            System.Drawing.Color[,] colorMatrix = null;
            colorMatrix = n.ColorSOFM();
            /* for (int i = 0; i < 10; i++)
             {
                 for (int j = 0; j < 10; j++)
                     Console.Write(Convert.ToString(colorMatrix[i, j]) + " ");
                 Console.WriteLine();
             }*/
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(colorMatrix[i, j].Name + " ");
                Console.WriteLine();
            }
            bcVisualization.Matrix = colorMatrix;
            Console.WriteLine("RA");
            bcVisualization.Invalidate();
            AddLegend();
            n.Normalize = true;
            length = n.Patterns.Count;
            for (int i = 0; i < length; i++)
            {
                if (i != 0 && i % 9 == 0)
                    Console.WriteLine();
                winners = n.FindWinner(n.Patterns[i]);
                Console.Write("[x={0} y={1}] ", winners.Coordinate.X, winners.Coordinate.Y);
            }
            Console.WriteLine("RA");
           
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            string sourceFile = "", destinationFile = @"C:\Users\maxim\Desktop\Class stuff\Third Year First Sem C1\Intelligent Systems 2\My Activities\top10spotify\sampletest.txt";
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
                File.AppendAllText(path, contents + "Input_Test");
                n = new NeuralNetwork((int)Math.Sqrt(1000), 10, 0.1, Functions.MexicanHat);
                // Habeeb, "Dubai Media City, Dubai"
                Console.WriteLine(path);
                n.ReadDataFromFile(path);
                //bpmVisualization
                bcVisualization.Matrix = null;
                n.Normalize = true;
                n.StartLearning();
                Console.WriteLine(n.Patterns.Count);
                Console.WriteLine("RE");
                System.Drawing.Color[,] colorMatrix = null;
                colorMatrix = n.ColorSOFM();
                /* for (int i = 0; i < 10; i++)
                 {
                     for (int j = 0; j < 10; j++)
                         Console.Write(Convert.ToString(colorMatrix[i, j]) + " ");
                     Console.WriteLine();
                 }*/
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                        Console.Write(colorMatrix[i, j].Name + " ");
                    Console.WriteLine();
                }
                bcVisualization.Matrix = colorMatrix;
                Console.WriteLine("RA");
                bcVisualization.Invalidate();
                AddLegend();
                n.Normalize = true;
                length = n.Patterns.Count;
                for (int i = 0; i < length; i++)
                {
                    if (i != 0 && i % 9 == 0)
                        Console.WriteLine();
                    winners = n.FindWinner(n.Patterns[i]);
                    Console.Write("[x={0} y={1}] ", winners.Coordinate.X, winners.Coordinate.Y);
                }
                Console.WriteLine("RA");
                File.Delete(destinationFile);
            }
            else
            {
                MessageBox.Show("LOAD DATA SET FIRST");
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
