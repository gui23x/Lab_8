using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8.LabCalculos.Lab07
{
    public partial class Telaprincipal : Form
    {
        public Telaprincipal()
        {
            InitializeComponent();
        }

        public void MaiordeTres()
        {
            int valor1 = Convert.ToInt32(nudValor1.Text);
            int valor2 = Convert.ToInt32(nudValor2.Text);
            int valor3 = Convert.ToInt32(nudValor3.Text);

            if (valor1 > valor2 && valor1 > valor3)
            {
                lblResultado.Text = " O maior Número é " + valor1.ToString();
            }
            else if (valor2 > valor1 && valor2 > valor3)
                    {
                lblResultado.Text = " O maior Número é " + valor2.ToString();
                    }
            else if (valor3 > valor1 && valor3 > valor2)
                    {
                lblResultado.Text = " O maior Número é " + valor3.ToString();
                    }
            else if (valor1 == valor2 && valor2 == valor3)
            {
                lblResultado.Text = "Todos são iguais".ToString();
                return;
            }
            else if (valor1 == valor2 && valor1 == valor3 )
            {
                lblResultado.Text = "o Resultado é ".ToString();
                return;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MaiordeTres();
        }
    }
}
