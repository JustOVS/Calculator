using System.Windows.Forms;
using System;

namespace Calc
{
    public static class Input
    {
        
        public static bool countForPoint = true;

        public static double firstNumber;

        //public static double secondNumber;

        public static IOperator sign;

        public static bool operatorFlag = false;
        public static void AddToBoard(string number, TextBox _board)
        {
            if (number == "0" && _board.Text == "0")
            {
            }
            else if (number == "," && _board.Text == "")
            {
                _board.Text += "0,";
                countForPoint = false;
            }
            else if (number == "," && countForPoint == false)
            {

            }
            else if (_board.Text == "0" && number != ",")
            {

            }
            else
            {
                _board.Text += number;
                if (number == ",")
                {
                    countForPoint = false;
                }
                operatorFlag = true;
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
            if (operatorFlag == true)
            {
                firstNumber = Convert.ToDouble(_board.Text);
                _board.Text = "";
                sign = new Adder();
                countForPoint = true;
                operatorFlag = false;
            }
        }

        public static void Subtract(TextBox _board)
        {
            if (operatorFlag = true)
            {
                firstNumber = Convert.ToDouble(_board.Text);
                _board.Text = "";
                sign = new Subtractor();
                countForPoint = true;
                operatorFlag = false;
            }
        }

        public static void Divide(TextBox _board)
        {
            if (operatorFlag = true)
            {
                firstNumber = Convert.ToDouble(_board.Text);
                _board.Text = "";
                sign = new Divider();
                countForPoint = true;
                operatorFlag = false;
            }
        }

        public static void Multiply(TextBox _board)
        {
            if (operatorFlag = true)
            {
                firstNumber = Convert.ToDouble(_board.Text);
                _board.Text = "";
                sign = new Multiplier();
                countForPoint = true;
                operatorFlag = false;
            }
        }

    }
}
