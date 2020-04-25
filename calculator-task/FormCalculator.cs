using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_task
{
    public partial class FormCalculator : Form
    {
        
        public FormCalculator()
        {
            InitializeComponent();
        }
        double result = 0;
        string operatorIsValue = "";
        private void FormCalculator_Load(object sender, EventArgs e)
        {
        }
        private  void Numbers_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtNumbers.Text.ToString() == "0")
                txtNumbers.Clear();
            txtNumbers.Text += btn.Text; 

        }
        private void Operator_Click(object sender, EventArgs e)
        {
            //TODO: Sonuç labelindaki operator ifadesi kontrol edilecek.
            //operatorIsValue = "";
            Button btn = (Button)sender;
            if(txtNumbers.Text.ToString() != "" || result > 0)
            {
                switch (btn.Text.ToString())
                {
                    case "+":
                        result = operatorIsValue == "=" ? result : result + Convert.ToDouble(txtNumbers.Text); 
                        lblResult.Text = "";
                        lblResult.Text = result.ToString() + " " + btn.Text;
                        txtNumbers.Clear();
                        operatorIsValue = "+";
                        break;
                    case "-":
                        if (operatorIsValue != "=")
                            result = result != 0 ? result - Convert.ToDouble(txtNumbers.Text) : Convert.ToDouble(txtNumbers.Text);
                        lblResult.Text = "";
                        lblResult.Text = result.ToString() + " " + btn.Text;
                        operatorIsValue = "-";
                        txtNumbers.Clear();
                        break;
                    case "/":
                        if (operatorIsValue != "=")
                            result = result != 0 ? result / Convert.ToDouble(txtNumbers.Text) : Convert.ToDouble(txtNumbers.Text);
                        lblResult.Text = "";
                        lblResult.Text = result.ToString() + " " + btn.Text;
                        txtNumbers.Clear();
                        operatorIsValue = "/";
                        break;
                    case "X":
                        if (operatorIsValue != "=")
                            result = result != 0 ? result * Convert.ToDouble(txtNumbers.Text) : Convert.ToDouble(txtNumbers.Text);
                        lblResult.Text = "";
                        lblResult.Text = result.ToString() + " " + btn.Text;
                        txtNumbers.Clear();
                        operatorIsValue = "*";
                        break;
                    case "=":
                        result = ClassCalculator.Operator(operatorIsValue, result, Convert.ToDouble(txtNumbers.Text));
                        lblResult.Text = "";
                        lblResult.Text = result.ToString();
                        txtNumbers.Clear();
                        operatorIsValue = "=";
                        break;
                }
            }
        }
        private void Result_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            txtNumbers.Clear();
        }
        private void TxtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result = 0;
            txtNumbers.Clear();
            txtNumbers.Focus();
            txtNumbers.Text = "0";
            lblResult.Text = "";
        }
    }
}
