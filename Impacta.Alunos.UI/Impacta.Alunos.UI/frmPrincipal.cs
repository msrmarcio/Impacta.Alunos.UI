using Impacta.alunos.UI;
using System;
using System.Windows.Forms;

namespace Impacta.Alunos.UI
{
    public partial class frmPrincipal : Form
    {

        // Quando executamos o processo de instanciação com a palavra NEW
        // estamos também executando o contrutor da classe que 
        // foi instaciada.
        // O Metodo construtor é o unico metodo que tem o mesmo nome
        // da classe, e não há nenhum tipo de retorno;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome">nome do usuario logado</param>
        public frmPrincipal(string nome)
        {
            // inicializa os componentes visuais
            // SE CASO PRECISAR PROGRAMAR ALGO NO METODO COSNTRUTOR
            // VOCÊ DEVE FAZE-LO APÓS O METODO InitializeComponent()
            InitializeComponent();

            // aqui podemos comecar a programar no construtor
            tssUsuario.Text = nome.ToUpper();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSobre().ShowDialog();
        }

        private void laboratório5Cap1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instanciamos o formulario para apresenta-lo
            new frmCalculadora().Show();
        }

        private void laboratório4Cap1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hERANÇAPOLIMORFISMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instanciar o formulario
            new frmOrientacaoObjetos().ShowDialog();
        }

        private void cadastroVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastroVeiculo().ShowDialog();
        }

        private void listaDeClientesArqDelimitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmListaClientes().ShowDialog();
        }
    }
}
