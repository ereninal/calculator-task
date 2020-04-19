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
        
        private void FormCalculator_Load(object sender, EventArgs e)
        {
            ClassCalculator.ClickEvent += new EventHandler(Btn_Click);
            ClassCalculator.KeyCreated(BoxKeys);
            //TODO: Dinamik button yerine elle forma buton eklecek ve sınıf yapısı ortadan kaldıracak.
        }
        private static void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(ClassCalculator.btn.Text);
        }
    }
}
