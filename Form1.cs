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

namespace SOFM
{
    public partial class Form1 : Form
    {
        private Point[,] bpm, energy, genre, dancability;
        private SOFM.NeuralNetwork nn;

        private float xSpace, ySpace;
        private int lines;
        public Form1()
        {
            InitializeComponent();
        }

        private void initializeGrid_Click(object sender, EventArgs e)
        {
            if( numOfLines.TextLength  == 0)
            {
                Console.WriteLine("Enter Size");
                return;
            }
            lines = Convert.ToInt32(numOfLines.Text);
            bpm = createGrid(bpmPanel,lines);
            genre = createGrid(genrePanel,lines);
            energy = createGrid(energyPanel,lines);
            dancability = createGrid(dancabilityPanel,lines);

            initializeGrid.Enabled = false;
            resetGrid.Enabled = true;

            //test para ma draw sa grid
            Graphics grid = bpmPanel.CreateGraphics();
            grid.FillRectangle(Brushes.Black, bpm[1, 1].X, bpm[1, 1].Y, xSpace, ySpace);
        }

        private void resetGrid_Click(object sender, EventArgs e)
        {
            numOfLines.Clear();
            bpmPanel.Invalidate();
            genrePanel.Invalidate();
            energyPanel.Invalidate();
            dancabilityPanel.Invalidate();

            Array.Clear(bpm, 0, lines * lines);
            Array.Clear(genre, 0, lines * lines);
            Array.Clear(energy, 0, lines * lines);
            Array.Clear(dancability, 0, lines * lines);

            initializeGrid.Enabled = true;
            resetGrid.Enabled = false;
        }

        private Point[,] createGrid(Panel panel,int lines)
        {
            Graphics grid = panel.CreateGraphics();
            Pen myPen = new Pen(Brushes.Black, 1);
            float x = 0f;
            float y = 0f;
            xSpace = ((panel.Width - myPen.Width) * 1.0f / lines);
            ySpace = ((panel.Height - myPen.Width) * 1.0f / lines);
 
            //vertical lines
            for (int i = 0; i < lines + 1; i++)
            {
                grid.DrawLine(myPen, x, y, x, ySpace * lines);
                x += xSpace;
            }

            //horizontal lines
            x = 0f;
            for (int i = 0; i < lines + 1; i++)
            {
                grid.DrawLine(myPen, x, y, xSpace * lines, y);
                y += ySpace;
            }

            //text
            x = 0f;
            y = 0f;


            Point[,] box = new Point[lines, lines];

            for (int r = 0; r < lines; r++)
            {
                for (int c = 0; c < lines; c++)
                {
                    box[r, c] = new Point((int)x, (int)y);

                    x += xSpace;
                }
                y += ySpace;
                x = 0f;

            }

            return box;
        }
    }
}
