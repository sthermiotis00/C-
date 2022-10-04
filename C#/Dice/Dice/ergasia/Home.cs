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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Exitbutton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //κανεις log in και αποθηκευει το username 
        private void login_button1_Click(object sender, EventArgs e)
        {


            if (txtuser.Text.Length > 0)
            {
                StreamWriter wr = new StreamWriter("highscores + .txt", true);
                wr.Write("Username:" + " " + txtuser.Text + " ");
                wr.Close();
                Main m = new Main();
                m.Show();
                
            }


            
              

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
