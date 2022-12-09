using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jokenpo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void imgPapel_Click(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            principal principal = new principal();
            principal.txtPontoPlayer.Text = txtPontoCenario.Text;
            principal.txtPontoEmpate.Text = txtEmpateCenario.Text;
            principal.txtPontoPC.Text = txtPontoPCCenario.Text;
            int.TryParse(txtPontoCenario.Text, out principal.pontoP);
            int.TryParse(txtEmpateCenario.Text, out principal.pontoEmp);
            int.TryParse(txtPontoPCCenario.Text, out principal.pontoE);
            principal.Show();
        }

        private void fechar2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void imgTesoura2_Click(object sender, EventArgs e)
        {
             
        }

        private void imgPapel2_Click(object sender, EventArgs e)
        {

        }

        private void imgPedra2_Click(object sender, EventArgs e)
        {

        }

        private void txtPontoCenario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPontoPCCenario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}