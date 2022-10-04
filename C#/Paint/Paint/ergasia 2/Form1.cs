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

namespace ergasia_2
{
    public partial class Form1 : Form
    {
        Point start, stop ; 
        Graphics g;
        Pen p,p1;//p για το μολυβι και p1 για το σπιτι
        int fsX1, fsY1, a, b, coundown = 9;
        bool freestyle, run = false;

        //Σβήσιμο του καμβά
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.CornflowerBlue);
        }

       

       

        private void Form1_Load(object sender, EventArgs e)
        {

            g = this.CreateGraphics();
            p = new Pen(Color.Black);
            p1 = new Pen(Color.Red,8);
        }

        //Εξοδος απο την εφαρμογή
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Για το πάχος του σχεδίου
        private void ThinknessButton1_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 1;
            p1.Width = 1;
        }

        private void ThiknessButton2_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 2;
            p1.Width = 2;
        }

        private void ThiknessButton3_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 3;
            p.Width = 3;
        }

        private void ThiknessButton4_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 4;
            p1.Width = 4;
        }

        private void ThiknessButton5_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 5;
            p1.Width = 5;
        }

        private void ThiknessButton6_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 6;
            p1.Width = 6;
        }

        private void ThiknessButton7_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 7;
            p1.Width = 7;
        }

        private void ThiknessButton8_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 8;
            p1.Width = 8;
        }

        private void ThiknessButton9_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 9;
            p1.Width = 9;
        }

        private void ThiknessButton10_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 10;
            p1.Width = 10;
        }

        private void ThiknessButton11_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 11;
            p1.Width = 11;
        }

        private void ThiknessButton12_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 12;
            p1.Width = 12;
        }

        private void ThiknessButton13_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 13;
            p1.Width = 13;
        }

        private void ThiknessButton14_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 14;
            p1.Width = 14;
        }

        private void ThiknessButton15_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 15;
            p1.Width = 15;
        }

        private void ThiknessButton16_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 16;
            p1.Width = 16;
        }

        private void ThiknessButton17_CheckedChanged(object sender, EventArgs e)
        {
            p.Width = 17;
            p1.Width = 17;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter sw =new  StreamWriter())
                {
                    sw.Write(p);
                }
            }
        }




        //Για το σπίτι ο χρόνος που θα ενεργοποιηθεί
        private void drawHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;

            }
            else
            {
                timer1.Enabled = true;
                coundown = 9;

            }
        }
        
        //Για το σπίτι ο σχεδιασμός
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            coundown--;
            if (coundown == 8)
            {
                g.DrawLine(p1, 300, 150, 300, 300);

            }
            else if (coundown == 7)
            {
                g.DrawLine(p1, 300, 300, 450, 300);

            }
            else if (coundown == 6)
            {
                g.DrawLine(p1, 450, 150, 450, 300);

            }
            else if (coundown == 5)
            {
                g.DrawLine(p1, 300, 150, 450, 150);

            }
            else if (coundown == 4)
            {
                Point[] pn = new Point[3];
                pn[0] = new Point(380, 10);
                pn[1] = new Point(300, 150);
                pn[2] = new Point(450, 150);
                g.DrawPolygon(p1, pn);
                
            }
            else if (coundown == 3)
            {
                g.DrawRectangle(p1, 320, 170, 30, 30);

            }
            else if(coundown == 2)
            {
                g.DrawRectangle(p1, 400, 170, 30, 30);

            }
            else if(coundown == 1)
            {
                g.DrawRectangle(p1, 360, 225, 30, 75);
            }
            else if(coundown == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("The House Is Complete!!!");
            }
            
        }

        
        // Για τα χρώματα
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                p.Color = colorDialog1.Color;
                p1.Color = colorDialog1.Color;
            }
        }

        
        public Form1()
        {

            InitializeComponent();
         
        }

        //Για τα σχήματα
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            freestyle = false;
            run = true;
            a = e.X - fsX1;
            b = e.Y - fsY1;
            Rectangle shape = new Rectangle(fsX1, fsY1, a, b);

            if (run)
            {
                if (CradioButton2.Checked)
                {
                    g.DrawEllipse(p, shape);
                    

                }
                else if (RradioButton2.Checked)
                {
                    g.DrawRectangle(p, shape);
                }
                else if (LradioButton1.Checked)
                {
                    if(e.Button == MouseButtons.Left)
                    {
                        stop = e.Location;
                        g.DrawLine(p, start, stop);
                    }
                }
                

            }
            


        }

        //Για τα σχήματα
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            freestyle = true;
            fsX1 = e.X;
            fsY1 = e.Y;
            if(e.Button == MouseButtons.Left)
            {
                start = e.Location;
            }
        }

        //Για τα σχήματα
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            label2.Text = e.X.ToString() + " , " + e.Y.ToString();
            if (freestyle)
            {
                if (FradioButton1.Checked)
                {
                    g.DrawLine(p, fsX1, fsY1, e.X, e.Y);
                    fsX1 = e.X;
                    fsY1 = e.Y;
                }
            }
        }

    }
}
