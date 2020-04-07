using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    class Divider : IOperator
    {
        public void DoMath(double tmp1, TextBox _board)
        {
            double result = tmp1 / Convert.ToDouble(_board.Text);
            _board.Text = result + "";
            Input.firstNumber = 0;
        }
    }
}
