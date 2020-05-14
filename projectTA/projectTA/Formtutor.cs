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
using System.Runtime.Remoting.Messaging;

namespace projectTA
{
    public partial class Formtutor : Form
    {
        public Formtutor()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(700);
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

    }
}
