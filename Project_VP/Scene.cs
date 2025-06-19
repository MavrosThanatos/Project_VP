using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using System.CodeDom;
using System.IO;

namespace Project_VP
{
    class Scene
    {
        // guestion:answer1,1;answer2,0;answer3,0;answer4,0; 
        private List<Question> questions = new List<Question>();
        private int num_q=-1;
        CheckedListBox prizeList;
        ProgressBar progressBarQuestion;
        Timer timerQuestion;
        public Scene()
        {
            AddQuestions();
            
        }
        private void AddQuestions() 
        {
            //TODO: openai API 

            /* PROMPT:
            "Generate 15 general knowledge quiz questions in this exact format:
            \"[Question text]?:[AnswerA],[1 or 0];[AnswerB],[1 or 0];[AnswerC],[1 or 0];[AnswerD],[1 or 0];\"
            Only one answer should be correct(marked with,1), and the others incorrect(marked with,0).
            Return it as a JSON list of strings."
            */

            //From file
            string fileName = "../../questions.json";
            string jsonString = File.ReadAllText(fileName);
            List<string> questionsArray = JsonSerializer.Deserialize<List<string>>(jsonString);
            List<string> chosenQuestions = GetRandomItems(questionsArray, 15);
            foreach (var item in chosenQuestions)
            {
                Question q = new Question(item);
                questions.Add(q);
            }

            /*Question q = new Question("Question 1?:AnswerA,1;AnswerB,0;AnswerC,0;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 2?:AnswerA,0;AnswerB,0;AnswerC,1;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 3?:AnswerA,1;AnswerB,0;AnswerC,0;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 4?:AnswerA,0;AnswerB,0;AnswerC,1;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 5?:AnswerA,0;AnswerB,0;AnswerC,1;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 6?:AnswerA,1;AnswerB,0;AnswerC,0;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 7?:AnswerA,0;AnswerB,0;AnswerC,1;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 8?:AnswerA,0;AnswerB,0;AnswerC,1;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 9?:AnswerA,1;AnswerB,0;AnswerC,0;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 10?:AnswerA,0;AnswerB,0;AnswerC,1;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 11?:AnswerA,0;AnswerB,0;AnswerC,1;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 12?:AnswerA,1;AnswerB,0;AnswerC,0;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 13?:AnswerA,0;AnswerB,0;AnswerC,1;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 14?:AnswerA,1;AnswerB,0;AnswerC,0;AnswerD,0;");
            //questions.Add(q);
            //q = new Question("Question 15?:AnswerA,0;AnswerB,0;AnswerC,1;AnswerD,0;");
            //questions.Add(q);
            //string p = JsonSerializer.Serialize(questions);
            //Console.WriteLine(p);*/
        }

        private List<string> GetRandomItems(List<string> array, int v)
        {
            Random rnd = new Random();

            // Shuffle the list using OrderBy and Take the first count elements
            return array.OrderBy(x => rnd.Next()).Take(v).ToList();

        }

        public void Set(CheckedListBox prizeList, ProgressBar progressBarQuestion, Timer timerQuestion)
        {
            this.prizeList = prizeList;
            this.progressBarQuestion = progressBarQuestion;
            this.timerQuestion = timerQuestion;
        }
        public void Win() 
        {
            this.timerQuestion.Stop();
            MessageBox.Show("WIN");
        }
        public void Lose() 
        {  
            this.timerQuestion.Stop();
            MessageBox.Show("LOSE");
        }
        public Question Next() 
        {
            num_q++;
            progressBarQuestion.Value = 100;
            if (num_q == questions.Count)
            {
                Win();
                return new Question("");
            }
            else
            {
                
                prizeList.SetSelected(questions.Count-num_q-1, true);
                if (num_q !=0)
                {
                    prizeList.SetItemChecked(questions.Count - num_q, true);
                }
                return questions[num_q];
            }
            
        }

    }
}
