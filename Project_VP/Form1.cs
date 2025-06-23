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
        Scene scene;
        Question q;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            scene = new Scene();
            scene.Set(prizeList, progressBarQuestion, timerQuestion);
            
        }
        private void ShowQuestion(Question q)
        {
            question.Items.Clear();
            if (q.Q==null)
            {
                answerA.Text = "";
                answerB.Text = "";
                answerC.Text = "";
                answerD.Text = "";
                return;   
            }
            question.Items.Add(q.Q);
            answerA.Text = q.Answers[0].A;
            answerB.Text = q.Answers[1].A;
            answerC.Text = q.Answers[2].A;
            answerD.Text = q.Answers[3].A;
        }
        private bool CheckAnswer(string a) 
        {
            if (a==q.Correct.A) 
            {
                return true;
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            q = scene.Next();
            ShowQuestion(q);
        }

        private void timerQuestion_Tick(object sender, EventArgs e)
        {
            progressBarQuestion.Increment(-1);
            if (progressBarQuestion.Value==0)
            {
                timerQuestion.Stop();
                scene.EndQuiz();
            }
        }

        private void answerA_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(answerA.Text))
            {
                q = scene.Next();
                ShowQuestion(q);
            }
            else 
            {
                scene.EndQuiz();
            }
        }

        private void answerB_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(answerB.Text))
            {
                q = scene.Next();
                ShowQuestion(q);
            }
            else
            {
                scene.EndQuiz();
            }
        }

        private void answerC_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(answerC.Text))
            {
                q = scene.Next();
                ShowQuestion(q);
            }
            else
            {
                scene.EndQuiz();
            }
        }

        private void answerD_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(answerD.Text))
            {
                q = scene.Next();
                ShowQuestion(q);
            }
            else
            {
                scene.EndQuiz();
            }
        }


    }
}
