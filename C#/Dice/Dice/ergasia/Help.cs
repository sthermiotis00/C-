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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string readText = File.ReadAllText("highscores.txt"); // Read the contents of the file
            Console.WriteLine(readText);
        }

        private void Back_button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
