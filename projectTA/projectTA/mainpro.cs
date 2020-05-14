using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projectTA
{
    public partial class mainpro : Form
    {
        int score = 0 ;
        int count = 3600;
        

        //random label color
        Random rand = new Random();
        string[] ColorName = { "PINK", "BLACK", "WHITE", "GREEN", "RED", "BLUE", "YELLOW" };
        Color[] colors = { Color.Pink, Color.Black, Color.White, Color.Green, Color.Red, Color.Blue, Color.Yellow };


        public mainpro()
        {
            InitializeComponent();
            this.ActiveControl = radioButton1;
            this.ActiveControl = radioButton2;
            this.ActiveControl = radioButton3;
            this.ActiveControl = radioButton4;
            this.ActiveControl = radioButton5;
            this.ActiveControl = radioButton6;
            this.ActiveControl = radioButton7;
            pictureBox1.Visible = false;
            label6.Visible = false;
        }
        private void WaitNSeconds(int seconds)
        {
            if (seconds < 700) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                Thread.Sleep(700);
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(700);
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(700);
            this.Hide();
            Formtutor tut = new Formtutor();
            tut.Show();
        }

        private void radioButton7_KeyDown(object sender, KeyEventArgs e)
        {
            {
                timer1.Start();
                label3.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                Thread.Sleep(700);

                //game score
                if (radioButton1.Checked)
                {
                    if (label1.ForeColor == Color.Pink)
                    {
                        score++;
                        point.Text = score.ToString();
                        if (e.KeyCode == Keys.Enter)
                        {

                        }                       
                    }
                    
                }
                if (radioButton2.Checked)
                {
                    if (label1.ForeColor == Color.Black)
                    {
                        score++;
                        point.Text = score.ToString();
                        if (e.KeyCode == Keys.Enter)
                        {

                        }
                    }

                }
                if (radioButton3.Checked)
                {
                    if (label1.ForeColor == Color.White)
                    {
                        score++;
                        point.Text = score.ToString();
                        if (e.KeyCode == Keys.Enter)
                        {

                        }
                    }

                }
                if (radioButton4.Checked)
                {
                    if (label1.ForeColor == Color.Green)
                    {
                        score++;
                        point.Text = score.ToString();
                        if (e.KeyCode == Keys.Enter)
                        {

                        }
                    }

                }
                if (radioButton5.Checked)
                {
                    if (label1.ForeColor == Color.Red)
                    {
                        score++;
                        point.Text = score.ToString();
                        if (e.KeyCode == Keys.Enter)
                        {

                        }
                    }

                }
                if (radioButton6.Checked)
                {
                    if (label1.ForeColor == Color.Blue)
                    {
                        score++;
                        point.Text = score.ToString();
                        if (e.KeyCode == Keys.Enter)
                        {

                        }
                    }

                }
                if (radioButton7.Checked)
                {
                    if (label1.ForeColor == Color.Yellow)
                    {
                        score++;
                        point.Text = score.ToString();
                        if (e.KeyCode == Keys.Enter)
                        {

                        }
                    }

                }

                //random color text
                int indexColorName = rand.Next(ColorName.Length);
                int changecolor = rand.Next(colors.Length);

                this.label1.Text = ColorName[indexColorName];
                this.label1.ForeColor = colors[changecolor];

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                count--;
                if (count != 0 && count > 0)
                {
                    label4.Text = count / 60 + ":" + ((count % 60) >= 1 ? (count % 60).ToString() : "0" + (count % 60));
                }
                else
                {
                    label4.Text = "0";
                    label1.Text = "TIME UP";
                    pictureBox1.Visible = true;
                    label6.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    radioButton7.Checked = false;
                    
                }

        }

        private void mainpro_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Thread.Sleep(700);
            mainpro main = new mainpro();
            main.Show();
        }
    }
}


