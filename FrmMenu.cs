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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPesoPlaneta frmpeso = new FrmPesoPlaneta();
            frmpeso.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMaiorMenor frmmaiormenor = new FrmMaiorMenor();
            frmmaiormenor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPlacar frmplacar = new FrmPlacar();
            frmplacar.Show();
            this.Hide();
        }
    }
}
