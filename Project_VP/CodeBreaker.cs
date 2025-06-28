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
    public partial class CodeBreaker : Form
    {
        public bool Correct { get; set; } = false;
        private Random rand { get; set; } = new Random();
        private int isOdd;
        private int length;
        private int sum;
        public CodeBreaker()
        {
            InitializeComponent();
            isOdd = (int)Math.Round(rand.NextDouble());
            length = rand.Next(3) + 2;
            sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += rand.Next(9);
            }
        }
        private void CodeBreaker_Load(object sender, EventArgs e)
        {
            string q = string.Format("The code is a {0}-digit number\n{1}\nThe sum of it's digits is {2}", length, isOdd == 1 ? "It's odd" : "It's even", sum);
            label1.Text = q;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int number = int.Parse(textBox1.Text);
                Console.WriteLine(number);
                textBox1.Text = "";
                bool correctParity = number % 2 == isOdd;
                bool correctLength = number.ToString().Length == length;
                char[] charArr = number.ToString().ToCharArray();
                int[] numArr = new int[charArr.Length];
                for (int i = 0; i < charArr.Length; i++)
                {
                    numArr[i] = int.Parse(charArr[i].ToString());
                }
                int s = numArr.Sum();
                bool correctSum = s == sum;
                if (correctParity && correctLength && correctSum)
                {
                    Correct = true;
                    ReturnAnswer();
                }
                else
                {
                    ReturnAnswer();
                }
            }
        }
        private bool ReturnAnswer()
        {
            this.Close();
            return Correct;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(-1);
            if (progressBar1.Value == 0)
            {
                timer1.Stop();
                ReturnAnswer();
            }
        }
    }
}
