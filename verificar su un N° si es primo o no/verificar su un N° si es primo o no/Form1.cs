using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verificar_su_un_N__si_es_primo_o_no
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int a=0,i,n;
             n = Convert.ToInt32(txtnum1.Text);
             for(i=1;i<(n+1);i++){
             if(n%i==0){
                 a++;
                }
             }
             if(a!=2){
                  MessageBox.Show("No es Primo");
                }else{
                  MessageBox.Show("Si es Primo");
             }
              
        }

    }
}
