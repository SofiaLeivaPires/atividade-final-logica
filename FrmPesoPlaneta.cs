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
    public partial class FrmPesoPlaneta : Form
    {
        public FrmPesoPlaneta()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // Mostra o peso na caixa de texto 
            try
            {
                // Variaveis locais
                double peso, pesoPlaneta;
                
                //Pega o valor e se nao for um valor válido, aparece a mensagem
                if (!double.TryParse(txtPeso.Text, out peso))
                {
                    MessageBox.Show("Insira um valor válido");
                    return;
                }

                // Se o Mercúrio for escolhido é efetuada a conta e imprimi o resultado 
                if (btnMercurio.Checked)
                {
                    pesoPlaneta = peso * 0.37;
                    MessageBox.Show("O seu peso em Mercúrio é " + pesoPlaneta);
                }

                // Se Vênus for escolhido é efetuada a conta e imprimi o resultado
                else if (btnVenus.Checked)
                {
                    pesoPlaneta = peso * 0.88;
                    MessageBox.Show("O seu peso em Vênus é " + pesoPlaneta);
                }

                // Se Marte for escolhido é efetuada a conta e imprimi o valor 
                else if (btnMarte.Checked)
                {
                    pesoPlaneta = peso * 0.38;
                    MessageBox.Show("O seu peso em Marte é " + pesoPlaneta);
                }

                // Se Júpiter for escolhido a conta é feita e imprimi o valor 
                else if (btnJupiter.Checked)
                {
                    pesoPlaneta = peso * 2.64;
                    MessageBox.Show("O seu peso em Júpiter é " + pesoPlaneta);
                }

                // Se Saturno for escolhido a conta e feita é imprimi o valor 
                else if (btnSaturno.Checked)
                {
                    pesoPlaneta = peso * 1.15;
                    MessageBox.Show("O seu peso em Saturno é " + pesoPlaneta);
                }

                // Se Urano for escolhido a conta é feita e o valor é mostrado 
                else if (btnUrano.Checked)
                {
                    pesoPlaneta = peso * 1.17;
                    MessageBox.Show("O seu peso em Urano é " + pesoPlaneta);
                }
            }


            catch (Exception ex)
            {
                // Exibe a mensagem de erro detalhada
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            //Clicando no botão menu, permite o retorno a tela principal
            //Instancia um novo objeto e pede pra mostrar e esconde a tela anterior
            FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            
        }
    }

}
