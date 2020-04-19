using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace calculator_task
{
    public class ClassCalculator
    {
        private string[] keys =
        {
            "7","8","9","/",
            "4","5","6","*",
            "1","2","3","-",
            "0",",","=","+"
        };
        public static void KeyCreated(FlowLayoutPanel panel)
        {
            for (int i = 0; i < 16; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString();
                btn.Text = i.ToString();
                btn.Width = 50;
                btn.Height = 50;
                panel.Controls.Add(btn);
            }
        }


    }
}
