using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_form_win
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (tbParteUm.Text != "")
            {
                var valor1 = Convert.ToDouble(tbParteUm.Text);
                var valor2 = Convert.ToDouble(tbParteDois.Text);
                //double soma = valor1 + valor2;
                tbResultado.Text = Convert.ToString(soma(valor1, valor2));
             }
            //MessageBox.Show("Digite um valor");
        }

        private double soma(double v1, double v2)
        {
            return v1 + v2;
        }

    }
}
