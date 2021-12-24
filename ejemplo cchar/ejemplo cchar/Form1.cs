using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_cchar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdaceptar_Click(object sender, EventArgs e)
        {
            int num1, num2=0;
            num1 = 0;
            //num1 = Convert.ToInt16(txtnum1.Text);
            for(int i=0 ; i < 5; i++)
            {
                if(i == 1)
                {
                    int j = 3;
                    if (j <= 2)
                    {
                        MessageBox.Show("i=1 y j=2");
                    }
                  
                }
            }
        }
    }
}
