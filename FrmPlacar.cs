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
    public partial class FrmPlacar : Form
    {
        public FrmPlacar()
        {
            InitializeComponent();
        }

        //Declara as variaveis
        string resultado;
        int gremio, palmeiras, santos, corinthians, pontePreta, flamengo, juventude, internacional, botafogo, cruzeiro, vasco, atleticoMineiro;

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAtleticoMineiro.Clear();
            textBoxBotafogo.Clear();
            textBoxCorinthians.Clear();
            textBoxCruzeiro.Clear();
            textBoxFlamengo.Clear();
            textBoxGremio.Clear();
            textBoxInternacional.Clear();
            textBoxJuventude.Clear();
            textBoxPalmeiras.Clear();
            textBoxPontePreta.Clear();
            textBoxSantos.Clear();
            textBoxVasco.Clear();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clicando no botão menu, permite o retorno a tela principal
            //Instancia um novo objeto e pede pra mostrar e esconde a tela anterior
            FrmMenu frmmenu = new FrmMenu();
            frmmenu.Show();

            this.Hide();
        }

       
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            //Recebe o placar dos gols
            gremio = int.Parse(textBoxGremio.Text);
            palmeiras = int.Parse(textBoxPalmeiras.Text);
            santos = int.Parse(textBoxSantos.Text);
            corinthians = int.Parse(textBoxCorinthians.Text);
            pontePreta = int.Parse(textBoxPontePreta.Text);
            flamengo = int.Parse(textBoxFlamengo.Text);
            juventude = int.Parse(textBoxJuventude.Text);
            internacional = int.Parse(textBoxInternacional.Text);
            botafogo = int.Parse(textBoxBotafogo.Text);
            cruzeiro = int.Parse(textBoxCruzeiro.Text);
            vasco = int.Parse(textBoxVasco.Text);
            atleticoMineiro = int.Parse(textBoxAtleticoMineiro.Text);

            //Faz a Verificação
            if (gremio < juventude)
            {
                labelResultado01.Text = ("Juventude");
            }
            else if (gremio > juventude)
            {
                labelResultado01.Text = ("Grêmio");
            }
            else
            {
                labelResultado01.Text = ("Empate");
            }

            if (palmeiras < internacional)
            {
                labelResultado02.Text = ("Internacional");
            }
            else if (palmeiras > internacional)
            {
                labelResultado02.Text = ("Palmeiras");
            }
            else
            {
                labelResultado02.Text = ("Empate");
            }

            if (santos < botafogo)
            {
                labelResultado03.Text = ("Botafogo");
            }
            else if (santos > botafogo)
            {
                labelResultado03.Text = ("Santos");
            }
            else
            {
                labelResultado03.Text = ("Empate");
            }

            if (corinthians < cruzeiro)
            {
                labelResultado04.Text = ("Cruzeiro");
            }
            else if (corinthians > cruzeiro)
            {
                labelResultado04.Text = ("Corinthians");
            }
            else
            {
                labelResultado04.Text = ("Empate");
            }

            if (pontePreta < vasco)
            {
                labelResultado05.Text = ("Vasco");
            }
            else if (pontePreta > vasco)
            {
                labelResultado05.Text = ("Ponte Preta");
            }
            else
            {
                labelResultado05.Text = ("Empate");
            }

            if (flamengo < atleticoMineiro)
            {
                labelResultado06.Text = ("Atlético Mineiro");
            }
            else if (flamengo > atleticoMineiro)
            {
                labelResultado06.Text = ("Flamengo");
            }
            else
            {
                labelResultado06.Text = ("Empate");
            }
        }
    }
}
