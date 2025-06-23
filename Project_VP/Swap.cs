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
    public partial class Swap : Form
    {
        public Question q;
        public bool Correct { get; set; }
        public Swap(Question q)
        {
            InitializeComponent();
            this.q = q;
            question.Items.Add(q.Q);
            answerA.Text = q.Answers[0].A;
            answerB.Text = q.Answers[1].A;
            answerC.Text = q.Answers[2].A;
            answerD.Text = q.Answers[3].A;
        }
        private bool CheckAnswer(string a)
        {
            if (a == q.Correct.A)
            {
                return true;
            }
            return false;
        }
        private void Swap_Load(object sender, EventArgs e)
        {

        }

        private void answerA_Click(object sender, EventArgs e)
        {
            Correct = CheckAnswer(answerA.Text);
            ReturnAnswer();
        }

        private void answerB_Click(object sender, EventArgs e)
        {
            Correct = CheckAnswer(answerB.Text);
            ReturnAnswer();
        }

        private void answerC_Click(object sender, EventArgs e)
        {
            Correct = CheckAnswer(answerB.Text);
            ReturnAnswer();
        }

        private void answerD_Click(object sender, EventArgs e)
        {
            Correct = CheckAnswer(answerB.Text);
            ReturnAnswer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarQuestion.Increment(-1);
            if (progressBarQuestion.Value == 0)
            {
                timer1.Stop();
                Correct = false;
                ReturnAnswer();
            }

        }
        public bool ReturnAnswer() 
        {
            this.Close();
            return Correct;
        }
    }
}
