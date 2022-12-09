namespace jokenpo
{
    public partial class principal : Form
    {
        public int pontoP = 0, pontoE = 0, pontoEmp = 0;
        public principal()
        {
            InitializeComponent();

        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
        
            Form2 cenario = new Form2();
            this.Hide();
            cenario.Show();

            int jogo, escolha = 0;

            if (rdoPedra.Checked)
            {
                cenario.imgPedra.Show();
                escolha = 1;
                cenario.txtEmpateCenario.Text = txtPontoEmpate.Text;
                cenario.txtPontoCenario.Text = txtPontoPlayer.Text;
                cenario.txtPontoPCCenario.Text = txtPontoPC.Text;
            }
            if (rdoPapel.Checked)
            {
                cenario.imgPapel.Show();
                escolha = 2;
                cenario.txtEmpateCenario.Text = txtPontoEmpate.Text;
                cenario.txtPontoCenario.Text = txtPontoPlayer.Text;
                cenario.txtPontoPCCenario.Text = txtPontoPC.Text;
            }
            if (rdoTesoura.Checked)
            {
                cenario.imgTesoura.Show();
                escolha = 3;
                cenario.txtEmpateCenario.Text = txtPontoEmpate.Text;
                cenario.txtPontoCenario.Text = txtPontoPlayer.Text;
                cenario.txtPontoPCCenario.Text = txtPontoPC.Text;
            }

            Random aleatorio = new Random();

            jogo = aleatorio.Next(1, 4);

            switch (jogo)
            {
                case (1):
                    cenario.imgPedra2.Show();
                    break;
                case (2):
                    cenario.imgPapel2.Show();
                    break;
                case (3):
                    cenario.imgTesoura2.Show();
                    break;
                default:
                    MessageBox.Show("Digite uma opção válida!!!");
                    break;

            }

            if (escolha == jogo)
            {
                cenario.Indicador.Text=("EMPATE!");
                pontoEmp++;

                txtPontoEmpate.Text = pontoEmp.ToString();
               


            }
            else if (escolha == 1 && jogo == 3 || escolha == 2 && jogo == 1 || escolha == 3 && jogo == 2)
            {
                cenario.Indicador.Text = ("GANHOU!");
                pontoP++;
                txtPontoPlayer.Text = pontoP.ToString();

            }

            else
            {
                cenario.Indicador.Text = ("PERDEU!");
                pontoE++;
                txtPontoPC.Text = pontoE.ToString();

            }

            cenario.txtEmpateCenario.Text = txtPontoEmpate.Text;
            cenario.txtPontoCenario.Text = txtPontoPlayer.Text;
            cenario.txtPontoPCCenario.Text = txtPontoPC.Text;

        }

        private void rdoPedra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fechar1_Click(object sender, EventArgs e)
        {
            int player, pc, empate;
            int.TryParse(txtPontoPlayer.Text, out player);
            int.TryParse(txtPontoEmpate.Text, out empate);
            int.TryParse(txtPontoPC.Text, out pc);

            if (player>pc && player > empate)
            {
                MessageBox.Show("Você venceu o jogo!\n Até a próxima!");
            }
            
            else if(pc>player && pc>empate)
            {
                MessageBox.Show("Você perdeu o jogo!\n Boa sorte na próxima!");
            }
            else if(pc==player || pc==empate || player == empate) 
            {
                MessageBox.Show("Essa foi disputada, empate!\n Até a próxima!");
            }
            
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}