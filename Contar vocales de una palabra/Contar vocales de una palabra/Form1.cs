using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contar_vocales_de_una_palabra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Palabra; 
            int contador1 = 0, contador2 = 0;

            Palabra = Convert.ToString(txtpalabra.Text);

            for (int i = 0; i < Palabra.Length; i++)
            {
                contador1++;
            }
            for (int i = 0; i < Palabra.Length; i++)
            {
                if ((Palabra[i] == 'a') || (Palabra[i] == 'e') || (Palabra[i] == 'i') || (Palabra[i] == 'o') || (Palabra[i] == 'u'))
                {
                    contador2++;

                }
            }
            MessageBox.Show("La palabra " + Palabra + " tiene " + contador2 + " Vocales.");
            
        }
        
        }
    }

