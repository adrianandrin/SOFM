using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using SOFM;

namespace SOFM
{
    public partial class Form1 : Form
    {
        private SOFM.NeuralNetwork nn;
        private List<string[]> songs;
        private List<string[]> genres;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var path = @"C:\Users\maxim\Desktop\Class stuff\Third Year First Sem C1\Intelligent Systems 2\My Activities\top10spotify\top10s.csv"; // Habeeb, "Dubai Media City, Dubai"
           // var path2 = @"C:\Users\maxim\Desktop\Class stuff\Third Year First Sem C1\Intelligent Systems 2\My Activities\top10spotify\genres.csv"; // Habeeb, "Dubai Media City, Dubai"
             NeuralNetwork n = new NeuralNetwork(10, 5, 0.01, Functions.Discrete);
             var path = @"C:\Users\maxim\Desktop\Class stuff\Third Year First Sem C1\Intelligent Systems 2\My Activities\top10spotify\genreWithVal.csv"; // Habeeb, "Dubai Media City, Dubai"
             n.ReadDataFromFile(path);
             n.StartLearning();
             for(int i = 0; i < n.Patterns.Count; i++)
             {
                 if (i != 0 && i % 9 == 0)
                     Console.WriteLine();
                 Neuron temp = n.FindWinner(n.Patterns[i]);
                 Console.Write("[x={0} y={1}] ",temp.Coordinate.X,temp.Coordinate.Y);
             }
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
    }
}
