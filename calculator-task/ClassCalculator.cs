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
        
        public static double Add(string get_result,string number)
        {
            double result = 0;
            return result = Convert.ToDouble( get_result) + Convert.ToDouble(number);
        }
        public static double Sub(string get_result, string number)
        {
            double result = 0;
            return result = get_result != "0" ? Convert.ToDouble(get_result) - Convert.ToDouble(number) : Convert.ToDouble(number);
        }
        public static double Operator(this string logic, int x, int y)
        {
            switch (logic)
            {
                case "+": return x + y;
                case "-": return x - y;
                case "*": return x * y;
                case "/": return x / y;
                default: throw new Exception("Error");
            }
        }
    }
}
