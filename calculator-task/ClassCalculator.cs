using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace calculator_task
{
    public static class ClassCalculator
    {

        public static double Operator(string oprt, double n1, double n2)
        {

            switch (oprt)
            {
                case "-": return n1 - n2;
                case "*": return n1 * n2;
                case "+": return n1 + n2;
                case "/": return n1 / n2;
                default: return 0;
            }

        }
    }
}
