using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversorMoedas
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void texbDolar_Leave(object sender, EventArgs e)
        {
            // Variavel
            decimal resultado;
            // Verifica se os campos não estão vazios
            if(txbCota.Text != ""&& txbDolar.Text !="")
            {
                // Converte, multiplica e armazena na variavel
                resultado = Convert.ToDecimal(txbCota.Text) * Convert.ToDecimal(txbDolar.Text);

                lblReais.Text = resultado.ToString("C");
                // C = Converter o número para Moeda (Coin)
            }
            else
            {
                MessageBox.Show("Digite Algo!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
