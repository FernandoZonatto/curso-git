using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtIMC.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);

            txtIMC.Text = imc.ToString("0.00");

            if (imc < 18.49)
            {
              
                txtResultado.Text = Convert.ToString("Situação: Voce esta abaixo do peso" );
            }
            else if (imc < 24.99)
                MessageBox.Show("Situação: Voce esta com o peso dentro da noramlidade", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("Situação: Voce está Acima do peso", "calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("Atenção! Voce esta com obesidade Grau I", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("Atenção! Voce esta com obesidade Grau II", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("Atenção! Voce esta com obesidade Grau III", "Calculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                   
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            txtPeso.Focus();
            txtPeso.Select();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
