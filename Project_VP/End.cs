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
    public partial class End: Form
    {
        public int Amount { get; set; }
        public bool Won { get; set; }

        public End()
        {
            InitializeComponent();
        }

        private void End_Load(object sender, EventArgs e)
        {
            if (Won)
            {
                label1.Text = "Congragulation you have won: " + "$" + Amount;
            }
            else
            {
                label1.Text = "Sorry try again, you have won: " + "$" + Amount;
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
