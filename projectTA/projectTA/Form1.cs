using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projectTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep(700);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(700);
            this.Hide();
            Formtutor tutor = new Formtutor();
            tutor.Show();
        }

        private void playbutton_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep(700);
            this.Hide();
            mainpro main = new mainpro();
            main.Show();
        }
    }
}
