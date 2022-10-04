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

namespace ergasia
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //κλεινει το main form
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //κλεινει την εφαρμογη
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //σε μεταφερει στο επιπεδο 1
        private void level1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameLevel1 l1 = new GameLevel1();
            l1.Show();

        }
        //σε μεταφερει στο επιπεδο 2
        private void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameLevel2 l2 = new GameLevel2();
            l2.Show();
        }
        //σε μεταφερει στο επιπεδο 3
        private void level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameLevel3 l3 = new GameLevel3();
            l3.Show();
        }

        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //η δυσκολια των level
        
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help HL = new Help();
            HL.Show();



        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
