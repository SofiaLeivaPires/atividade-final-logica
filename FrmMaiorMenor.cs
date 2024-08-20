using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica_logica_de_programacao
{
    public partial class FrmMaiorMenor : Form
    {
        public FrmMaiorMenor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clicando no botão menu, permite o retorno a tela principal
            //Instancia um novo objeto e pede pra mostrar e esconde a tela anterior
            FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            this.Hide();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaração de váriaveis
            double a, b, c, maior, menor;

            // Recebe os valores
            a = double.Parse(txtV1.Text);
            b = double.Parse(txtV2.Text);
            c = double.Parse(txtV3.Text);

            maior = menor = a;

            // Verifica o maior e menor
            if (b > maior)
                maior = b;
            if (c > maior)
                maior = c;

            // Verifica o maior e menor
            if (b < menor)
                menor = b;
            if (c < menor)
                menor = c;

            // Mostra o maior e o menor
            lblMaior.Text = maior.ToString();
            lblMenor.Text = menor.ToString();

            // Se os tres valores forem iguais vai mostrar
            if (a == b && a == c && b == c)
            {
                MessageBox.Show("Os números são iguais");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa as caixas de texto
            txtV1.Clear();
            txtV2.Clear();
            txtV3.Clear();
            lblMaior.Text = " ";
            lblMenor.Text = " ";
        }
    }
}
