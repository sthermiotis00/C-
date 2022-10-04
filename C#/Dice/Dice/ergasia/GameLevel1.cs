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
    public partial class GameLevel1 : Form
    {
        int counter;
        Random random;
        int sum;
        int randomIm;
        int coundown = 60;
        

        public GameLevel1()
        {
            InitializeComponent();
        }
        //κλεινει το παιχνιδι
        private void exit_button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //μετραει το σκορ και τα χτηπηματα

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counter++;
            touches_label1.Text = counter.ToString();
            sum += randomIm;
            score_label1.Text = sum.ToString();
        }
        //μετραει τον χρονο

        private void timer1_Tick(object sender, EventArgs e)
        {
            randomIm = random.Next(1, 7);
            pictureBox1.ImageLocation = "images/Alea_" + randomIm.ToString() + ".png";
            int x1, y1;
            x1 = random.Next(this.Width - pictureBox1.Width);
            y1 = random.Next(this.Height - pictureBox1.Height);
            pictureBox1.Location = new Point(x1, y1);
            coundown--;
            Time_label1.Text = coundown.ToString();
            if (coundown == 0)
            {
                timer1.Enabled = false;
                pictureBox1.Enabled = false;
                this.Hide();
                StreamWriter write = new StreamWriter("highscores + .txt", true);
                
                write.WriteLine("Score:"+" " + sum + " "+ "Level: 1" );
                write.Close();

            }
        }
        //ξεκιναει το παιχνιδι

        private void start_button1_Click(object sender, EventArgs e)
        {
            random = new Random();
            if (timer1.Enabled)
            {
                timer1.Enabled = false;

            }
            else
            {
                timer1.Enabled = true;
            }
        }
        //τερματιζει το παιχνιδι οποτε θες 

        private void stop_button2_Click(object sender, EventArgs e)
        {
            coundown = 1;
            timer1.Enabled = false;
            pictureBox1.Enabled = false;
            this.Hide();

        }
    }
}
