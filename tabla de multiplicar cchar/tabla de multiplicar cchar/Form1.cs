using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabla_de_multiplicar_cchar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2 = 0;
            num1 = 0;
            num1 = Convert.ToInt16(txtnum1.Text);
            
            for (int i=0; i < 10; i++)
            {
                num2 = num1 * i;
                lbmultiplicar.Items.Add(num1 + "x" + i + "=" + num2);

            }
        }
    }
}
