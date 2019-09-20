using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        IAdditionOperation calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new BasicOperation();
        }

        private void Button1_Click(object sender, EventArgs e)
        {           
            lbl_result.Text = $"The addition of a nd b is {calculator.SubstractTwoNumbers(txt_val1.Text, txt_val2.Text)}";
        }
    }
}
