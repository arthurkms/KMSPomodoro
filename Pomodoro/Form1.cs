using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerTableLabel.Text = DateTime.Now.ToString("mm:ss tt");
            TimerTableLabel.Refresh();
        }

        private void workTimeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //8 signifies backspace
            if (!Char.IsDigit(ch) && ch!= 8)
            {
                e.Handled = true;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            TimerTableLabel.Text = DateTime.Now.ToString("mm:ss tt");
            timer1.Start();
        }
    }
}
