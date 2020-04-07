using System.Windows.Forms;
using System;

namespace Calc
{
    public static class Input
    {
        
        private static bool countForPoint = true;

        public static double firstNumber;

        //public static double secondNumber;

        public static IOperator sign;
        public static void AddToBoard(string number, TextBox _board)
        {
            if (number == "0" && _board.Text == "0")
            {
            }
            else if (number == "." && _board.Text == "")
            {
                _board.Text += "0.";
                countForPoint = false;
            }
            else if (number == "." && countForPoint == false)
            {

            }
            else
            {
                _board.Text += number;
                if (number == ".")
                {
                    countForPoint = false;
                }
            }
        }

        public static void swapSign(TextBox _board)
        {
            if (_board.Text.Contains("-"))
            {
                _board.Text = _board.Text.Replace("-", "");
            }
            else
            {
                _board.Text = _board.Text.Insert(0, "-");
            }
        }

        public static void Add(TextBox _board)
        {
            firstNumber = Convert.ToDouble(_board.Text);
            _board.Text = "";
            sign = new Adder();
        }
    }
}
