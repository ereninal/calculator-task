using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace calculator_task
{
    public class ClassCalculator
    {
        public static event EventHandler ClickEvent;
        public static Button btn;
        protected static string[] keys =
        {
            "7","8","9","/",
            "4","5","6","*",
            "1","2","3","-",
            "0",",","=","+"
        };
        public static void KeyCreated(GroupBox box)
        {
            byte keyValue = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <4; j++)
                {
                    btn = new Button();
                    btn.Name = i.ToString();
                    btn.Text = keys[keyValue].ToString();
                    btn.Width = 45;
                    btn.Height = 45;
                    btn.Location = new Point( 8+ j*48, 11 + i*49);
                    btn.Click += ClickEvent;
                    box.Controls.Add(btn);
                    keyValue++;
                }
            }
        }
    }
}
