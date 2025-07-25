﻿using System;
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
        private Question swap;
        private int num_q=-1;
        CheckedListBox prizeList;
        ProgressBar progressBarQuestion;
        Timer timerQuestion;
        public End End { get; set; } = new End();
        public Swap SwapQuestion { get; set; }
        public Wordle WordleQuestion { get; set; }
        public TicTacToe TicTacToeQuestion { get; set; }
        public CodeBreaker CodeBreakerQuestion { get; set; }
        public int WinAmount { get; set; }
        private int[] amounts = { 0, 1000, 32000, 1000000 };
        private int rank = 0;

        private static string fileName = "../../questions.json";
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
            string jsonString = File.ReadAllText(fileName);
            List<string> questionsArray = JsonSerializer.Deserialize<List<string>>(jsonString);
            List<string> chosenQuestions = GetRandomItems(questionsArray, 16);
            foreach (var item in chosenQuestions)
            {
                if (swap==null)
                {
                    swap = new Question(item);
                }
                else
                {
                    Question q = new Question(item);
                    questions.Add(q);
                }    
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
        public void EndQuiz() 
        {  
            this.timerQuestion.Stop();
            End.Won = num_q==15?true:false;
            End.Amount = WinAmount;
            End.Show();
        }
        public Question Next() 
        {
            num_q++;
            progressBarQuestion.Value = 100;
            if (num_q % 5 == 0)
            { 
                WinAmount = amounts[rank++];
            }
            if (num_q == questions.Count)
            {
                
                EndQuiz();
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

        public bool Swap() 
        {
            SwapQuestion = new Swap(swap);
            timerQuestion.Stop();
            SwapQuestion.ShowDialog();
            timerQuestion.Start();
            return SwapQuestion.Correct;
        }
        public bool Worlde() 
        {
            WordleQuestion = new Wordle();
            timerQuestion.Stop();
            WordleQuestion.ShowDialog();
            timerQuestion.Start();
            return WordleQuestion.Correct;
        }
        public bool TicTacToe() 
        {
            TicTacToeQuestion = new TicTacToe();
            timerQuestion.Stop();
            TicTacToeQuestion.ShowDialog();
            timerQuestion.Start();
            return TicTacToeQuestion.Correct;
        }
        public bool CodeBreaker() 
        {
            CodeBreakerQuestion = new CodeBreaker();
            timerQuestion.Stop();
            CodeBreakerQuestion.ShowDialog();
            timerQuestion.Start();
            return CodeBreakerQuestion.Correct;
        }

    }
}
