using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_VP
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Scene scene = new Scene();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            progressBarQuestion.Increment(-1);
            if (progressBarQuestion.Value==0)
            {
                timerQuestion.Stop();
                //TODO: add "you lose" function
            }
        }
    }
}
