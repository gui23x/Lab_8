using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8.LabCalculos.Lab08
{
    public partial class Telaprincipal : Form
    {
        public Telaprincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo();
        }

        private void Calculo()
        {
            decimal valor = 0;
            decimal porcento = 0;
            decimal valorFinal = 0;

            valor = Convert.ToDecimal(tbxValor.Text);
            //porcento = Convert.ToDecimal(tbxFrete.Text);

            switch (tbxUf.Text.ToString())
            {
                case "AM":
                    porcento = 0.6m;
                    break;
                case "MG":
                    porcento = 0.35m;
                    break;
                case "RJ":
                    porcento = 0.3m;
                    break;
                case "SP":
                    porcento = 0.2m;
                    break;
                default:
                    porcento = 0.75m;
                    break;


            }
            tbxFrete.Text = porcento.ToString();
            valorFinal = valor * (1 + porcento);

            lblResultado.Text = valorFinal.ToString();

        }
    }
}
