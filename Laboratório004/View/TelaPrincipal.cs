using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratório004.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(tbxNumero.Text == "")
            {
                MessageBox.Show("Insira um número");

            }
            else
            { 
            int numero = 0;
            int quadrado = 0;

            numero = Convert.ToInt32(tbxNumero.Text);

            quadrado = numero * numero;

            lblResultado.Text = "o número" + numero + "ao quadrado é" + quadrado.ToString();
                tbxNumero.Focus();
                tbxNumero.SelectAll();
                
            }
        }

        private void TelaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                {
                e.Handled = true;

                if (e.KeyChar == 13)
                { 
                    btnCalcular.PerformClick();
                }
            }
        }
    }
}
