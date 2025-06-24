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
    public partial class TicTacToe : Form
    {
        private Button[] buttons;
        private int[] moves = new int[9];
        private readonly int[][] winPatterns = new int[][]
        {
            new int[] {0, 1, 2},
            new int[] {3, 4, 5},
            new int[] {6, 7, 8},
            new int[] {0, 3, 6},
            new int[] {1, 4, 7},
            new int[] {2, 5, 8},
            new int[] {0, 4, 8},
            new int[] {2, 4, 6}
        };
        public bool Correct { get; set; } = false;
        public TicTacToe()
        {
            InitializeComponent();
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }
        private bool MovesLeft()
        {
            foreach (var item in moves)
            {
                if (item == 0)
                {
                    return true;
                }
            }
            return false;
        }
        private int Eval()
        {
            foreach (var pattern in winPatterns)
            {
                int a = pattern[0];
                int b = pattern[1];
                int c = pattern[2];

                if (moves[a] != 0 &&
                    moves[a] == moves[b] &&
                    moves[b] == moves[c])
                {
                    return moves[a] == 1 ? 10 : -10;
                }
            }
            return 0;
        }
        private float MiniMax(int depth, bool isPlayer)
        {
            int score = Eval();

            if (score == 10)
                return score - depth;  // player wins
            if (score == -10)
                return score + depth;  // AI wins
            if (!MovesLeft())
                return 0;

            if (isPlayer)
            {
                float best = float.NegativeInfinity;
                for (int i = 0; i < moves.Length; i++)
                {
                    if (moves[i] == 0)
                    {
                        moves[i] = 1;
                        best = Math.Max(best, MiniMax(depth + 1, false));
                        moves[i] = 0;
                    }
                }
                return best;
            }
            else
            {
                float best = float.PositiveInfinity;
                for (int i = 0; i < moves.Length; i++)
                {
                    if (moves[i] == 0)
                    {
                        moves[i] = -1;
                        best = Math.Min(best, MiniMax(depth + 1, true));
                        moves[i] = 0;
                    }
                }
                return best;
            }
        }
        private float Expectimax(int depth, bool isPlayer)
        {
            int score = Eval();

            if (score == 10)
                return score - depth;  // Player wins
            if (score == -10)
                return score + depth;  // AI wins
            if (!MovesLeft())
                return 0;

            if (isPlayer)
            {
                float best = float.NegativeInfinity;
                for (int i = 0; i < moves.Length; i++)
                {
                    if (moves[i] == 0)
                    {
                        moves[i] = 1;
                        best = Math.Max(best, Expectimax(depth + 1, false));
                        moves[i] = 0;
                    }
                }
                return best;
            }
            else
            {
                float total = 0;
                int count = 0;

                for (int i = 0; i < moves.Length; i++)
                {
                    if (moves[i] == 0)
                    {
                        moves[i] = -1;
                        total += Expectimax(depth + 1, true);
                        moves[i] = 0;
                        count++;
                    }
                }

                return count == 0 ? 0 : total / count; // Expected value
            }
        }

        private int FindBestMove()
        {
            float bestValue = float.PositiveInfinity;
            int bestMove = -1;

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 0)
                {
                    moves[i] = -1;
                    float moveValue = Expectimax(0, true);
                    moves[i] = 0;
                    if (moveValue < bestValue)
                    {
                        bestValue = moveValue;
                        bestMove = i;
                    }
                }
            }
            Console.WriteLine(bestValue);
            return bestMove;
        }
        private void MakeMove(int index, bool isPlayer)
        {
            if (moves[index] != 0)
                return;

            if (isPlayer)
            {
                buttons[index].Text = "X";
                moves[index] = 1;
            }
            else
            {
                buttons[index].Text = "O";
                moves[index] = -1;
            }

            buttons[index].Enabled = false;
        }
        private bool CheckWin()
        {
            int result = Eval();
            if (result == 10)
            {
                Console.WriteLine("Player");
                Correct = true;
                return true;
            }
            else if (result == -10)
            {
                Console.WriteLine("AI");
                Correct = false;
                return true;
            }
            else if (!MovesLeft())
            {
                Console.WriteLine("Draw");
                Correct = true;
                return true;
            }
            return false;

        }
        private void Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string name = button.Name;
            int index = int.Parse(name[name.Length - 1].ToString()) - 1;

            MakeMove(index, true);
            if (CheckWin()) // Player won
            {
                Console.WriteLine(Correct);
                this.Close();
                return;
            }

            if (!MovesLeft() || Eval() != 0)
            {
                return; // Stop if draw or win already occurred
            }

            int AIMove = FindBestMove();
            if (AIMove != -1)
            {
                MakeMove(AIMove, false);
                if (CheckWin()) // AI might win here
                {
                    this.Close();
                    return;
                }
            }
        }
        public bool ReturnAnswer()
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