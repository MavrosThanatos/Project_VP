using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Project_VP
{
    public partial class Wordle: Form
    {
        public bool Correct { get; set; } = false;
        private string word;
        private int word_num = 0;
        private int index = 0;
        private static string fileName = "../../words.json";
        private TextBox[] boxes = {};
        public Wordle()
        {
            InitializeComponent();
            string jsonString = File.ReadAllText(fileName);
            List<string> words = JsonSerializer.Deserialize<List<string>>(jsonString);
            Random rand = new Random();
            int index = rand.Next(words.Count);
            word = words[index];
            Console.WriteLine(word);
            var allTexboxes = this.Controls.OfType<TextBox>();
            boxes = allTexboxes.OrderBy(name =>
            {
                var match = Regex.Match(name.Name, @"\d+$");
                return match.Success ? int.Parse(match.Value) : int.MaxValue;
            }).ToArray();
        }

        private void Wordle_Load(object sender, EventArgs e)
        {

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
        public bool ReturnAnswer() 
        {
            this.Close();
            return Correct;
        }
        public async Task CheckAnswer(string guess) 
        {
            int[] contains = new int[5];
            for (int i = 0; i < guess.Length; i++)
            {
                if (word[i].ToString().ToLower().Equals(guess[i].ToString().ToLower()))
                {
                    contains[i] = 2;
                }
                else if (word.ToString().ToLower().Contains(guess[i].ToString().ToLower()))
                {
                    contains[i] = 1;
                }
                else
                {
                    contains[i] = 0;
                }
            }
            SetCorrectCharacters(contains, guess);
            if (contains.Sum()==10)
            {
                Correct = true;
            }
            if (Correct || word_num==5)
            {
                await Task.Delay(1000);
                ReturnAnswer();
            }
            progressBar1.Value = 100;
        }

        private void SetCorrectCharacters(int[] contains, string guess)
        {
            Console.WriteLine(boxes.Length);
            for (int i = 0; i < contains.Length; i++)
            {
                boxes[index].Text = guess[i].ToString().ToUpper();
                if (contains[i]==2)
                {
                    boxes[index++].BackColor = Color.Green;
                }
                else if (contains[i]==1)
                {
                    boxes[index++].BackColor = Color.Yellow;
                }
                else
                {
                    boxes[index++].BackColor = Color.Gray;
                }
            }
            word_num++;
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxInput.Text.Length == 5)
                {
                    CheckAnswer(textBoxInput.Text);
                    textBoxInput.Text = "";
                    e.Handled = true;
                }
            }
        }
    }
}
