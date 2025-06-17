using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Project_VP
{
    class Answer 
    {
        public string A { get; set; }
        public bool isCorrect { get; set; }
        public Answer(string a) 
        {
            A = a.Split(',')[0];
            isCorrect = a.Split(',')[1]=="1"?true:false;
        }
    }
    class Question
    {
        static Random rng = new Random();
        public string Q { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public Answer Correct { get; set; }
        public void Shuffle()
        {
            //Fisher-Yates Shuffle
            List<Answer> list = this.Answers;
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Answer value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            this.Answers = list;
        }
        public Question(string q)
        {
            Console.WriteLine(q);
            if (q=="")
            {
                return;
            }
            Q = q.Split(':')[0];
            foreach (var item in q.Split(':')[1].Split(';'))
            {
                if (item.Equals(""))
                {
                    break;
                }
                Answers.Add(new Answer(item));
            }
            foreach (var item in Answers)
            {
                if (item.isCorrect)
                {
                    Correct = item;
                }
            }
            Shuffle();
        }


    }
}
