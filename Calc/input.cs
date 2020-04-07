using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public static class Input
    {
        
        private static bool countForPoint = true;
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
            if(_board.Text.Contains('-'))
            {
                _board.Text = _board.Text.Substring(0);
            }
            else
            {
                _board.Text = _board.Text.Insert(0, "-");
            }






        }
    }
}
