using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodicTable
{
    public partial class MainForm : Form
    {
        private int originalWidth, originalHeight;
        private Table table1;
        private int toggleNumber; //1, 2, 3, or 4 to toggle number, symbol, name, mass

        public MainForm()
        {
            InitializeComponent();
            originalWidth = Width;
            originalHeight = Height;

            table1 = new Table(0, 24);
            toggleNumber = 2;
        }

        //Resize
        private void MainForm_Resize(object sender, EventArgs e)
        {
            double scaleWidth = (double)(Width - 12) / (double)(originalWidth - 12); //-12 looks nicer? idk y
            double scaleHeight = (double)(Height - 12) / (double)(originalHeight - 12); //top menu = 24, half = 12

            if (Math.Abs(scaleWidth) <= Math.Abs(scaleHeight))
            {
                Table.Scale(scaleWidth);
            }
            else
            {
                Table.Scale(scaleHeight);
            }


            Invalidate();
        }

        //Help PopUp
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form instructions = new Instructions();
            instructions.ShowDialog();
        }

        //Show Parts
        private void ShowAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowAll(true);
            Invalidate();
        }
        private void ShowNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowNumbers(true);
            Invalidate();
        }
        private void ShowSymbolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowSymbols(true);
            Invalidate();
        }
        private void ShowNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowNames(true);
            Invalidate();
        }
        private void ShowMassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowMasses(true);
            Invalidate();
        }

        //Hide Parts
        private void HideAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowAll(false);
            Invalidate();
        }
        private void HideNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowNumbers(false);
            Invalidate();
        }
        private void HideSymbolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowSymbols(false);
            Invalidate();
        }
        private void HideNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowNames(false);
            Invalidate();
        }
        private void HideMassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table1.ShowMasses(false);
            Invalidate();
        }

        //KeyDown
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                toggleNumber = 1;
            }
            else if (e.KeyCode == Keys.D2)
            {
                toggleNumber = 2;
            }
            else if (e.KeyCode == Keys.D3)
            {
                toggleNumber = 3;
            }
            else if (e.KeyCode == Keys.D4)
            {
                toggleNumber = 4;
            }

            else if (e.KeyCode == Keys.S)
            {
                table1.ShowAll(true);
                Invalidate();
            }
            else if (e.KeyCode == Keys.H)
            {
                table1.ShowAll(false);
                Invalidate();
            }
        }

        //MouseDown
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (table1.Clicked(toggleNumber, e.X, e.Y))
            {
                Invalidate();
            }
        }

        //Paint
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            table1.Paint(e);
        }
    }
}
