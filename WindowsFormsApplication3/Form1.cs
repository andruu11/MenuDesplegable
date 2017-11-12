using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int pw;
        bool hide;
        int pwx;
        SoundPlayer a = new SoundPlayer(@"D:\Ayudantia\button.wav");
        public Form1()
        {
            InitializeComponent();
            pw = panel2.Width;
            pwx = panel2.Width - 150;
            hide = false;
            pictureBox2.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide)
            {
                panel2.Width = panel2.Width + 10;
                
                if (panel2.Width == pw)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    bunifuImageButton4.Location = new Point(154, 16);
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                }
            }
            else {
                panel2.Width = panel2.Width - 10;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                bunifuImageButton4.Location = new Point(3,16);
                
                if(panel2.Width == pwx){
                    
                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuFlatButton1_MouseMove(object sender, MouseEventArgs e)
        {
            
            a.Play();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form2 otro_form = new Form2();
            otro_form.Show();
            a.Play();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
            a.Play();
            panel3.Hide();
            panel4.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            a.Play();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            a.Play();
        }
    }
}
