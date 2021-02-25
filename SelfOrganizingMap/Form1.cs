using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            var path = @"D:\Adrian-Andrin\Documents\School\Intelligent System 2\SOFM\SelfOrganizingMap\sample.txt"; // Habeeb, "Dubai Media City, Dubai"
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
            /*
                songs = new List<string[]>();
                genres = new List<string[]>();
                TextFieldParser csvParser = new TextFieldParser(path);
                TextFieldParser parse = new TextFieldParser(path2);

                parse.CommentTokens = new string[] { "#" };
                parse.SetDelimiters(new string[] { "," });
                parse.HasFieldsEnclosedInQuotes = true;

                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                 // Skip the row with the column names
                csvParser.ReadLine();

                 while (!csvParser.EndOfData)
                    {
                        // Read current line fields, pointer moves to the next line.
                        string[] fields = csvParser.ReadFields();
                        songs.Add(fields);
                    }
                while (!parse.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] tem = parse.ReadFields();
                    genres.Add(tem);
                }
                List<string> temp = new List<string>();
                    for(int i = 0; i < songs.Count; i++)
                    {
                        for(int j = 0; j < 50; j++)
                        {
                            if(songs[i][3] == genres[j][1])
                        {
                            songs[i][3] = genres[j][0];
                        }
                        }              
                    }
                    //string[] genres = temp.Distinct().ToArray();
                    Console.WriteLine(songs.Count());
                    for (int i = 0; i < songs.Count(); i++)
                    {
                        Console.WriteLine(songs[i][3]);
                    }
                */
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
