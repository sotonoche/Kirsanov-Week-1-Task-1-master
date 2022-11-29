using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum1_Task1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            double x, y, res;

            x = Convert.ToDouble(NumericFirst.Value);
            y = Convert.ToDouble(NumericSecond.Value);

            res = Math.Sqrt(Math.Abs(x) * Math.Abs(y));
            textBoxResult.Text = Math.Round(res, 2).ToString();
        }
    }
}
