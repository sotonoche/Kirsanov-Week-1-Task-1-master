using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum1_Task2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown.Value);
            string res = Math.Abs(n) % 10 == 7 ? "Оканчивается на семь" : "Не оканчивается на семь";
            textBoxResult.Text = res;
        }
    }
}
