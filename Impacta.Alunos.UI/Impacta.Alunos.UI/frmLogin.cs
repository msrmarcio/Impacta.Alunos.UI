using System;
using System.Drawing;
using System.Windows.Forms;

namespace Impacta.Alunos.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // fechar o programa e fechar o formulario ao
            // tempo -  encerra a execução do software
            Application.Exit();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)
            {
                // SE O USUARIO FOI PREENCHIDO, PODEMOS VALIDAR A SENHA
                if (txtSenha.Text.Trim() != string.Empty)
                {
                    if (txtUsuario.Text == "marcio" && txtSenha.Text == "1234")
                    {
                        // se usuario esta correto e senha também
                        // enviamos uma msg de boas vindas com
                        // MessageBox
                        MessageBox.Show("Seja bem vindo a Impacta Tecnologia");

                        // escondemos o formulario de login
                        this.Hide();

                        // Precisamos Instanciar a classe do novo formulario
                        // para que se torne um objeto e seja possivel 
                        // utiliza-lo em tempo de execução
                        // Para instanciar temos duas formas, direta e indireta
                        // 1º direta: utilizado para formulario
                        // new: Palavra responsavel por Instanciar a classe
                        new frmPrincipal(txtUsuario.Text).Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha invalido");

                        // chama o metodo para limpar formulario
                        LimparCampos();

                        // foco no primeiro campo
                        txtUsuario.Focus();
                         
                    }
                }
                else
                {
                    // informa que usuario nao foi preenchido
                    MessageBox.Show("A Senha deve ser informada");

                    // coloca o foco do cursor no campo correto
                    txtSenha.Focus();
                }
            }
            else
            {
                // informa que usuario nao foi preenchido
                MessageBox.Show("Usuário deve ser informado", "Alerta",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                // coloca o foco do cursor no campo correto
                txtUsuario.Focus();
            }
        }
         
        private void LimparCampos()
        {
            // vamoslimpar os campos
            // aqui passamos um conteudo vazio para textbox
            txtUsuario.Text = "";

            // aqui vamos utilizar um comando do .net
            txtSenha.Text = string.Empty;

            // outra forma de limpar textbox
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            MudaCorFundo(txtUsuario);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            MudaCorFundo(txtUsuario);
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            MudaCorFundo(txtSenha);
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            MudaCorFundo(txtSenha);
        }

        /// <summary>
        /// Este metodo é responsavel por alterar a cor 
        /// do controle
        /// textbox, que será enviado no parametro
        /// </summary>
        /// <param name="txt">Será utilizado como referencia 
        /// para trocar a cor de fundo deste controle</param>
        private void MudaCorFundo(TextBox txt)
        {
            if (txt.BackColor != Color.Yellow)
            {
                txt.BackColor = Color.Yellow;
            }
            else
            {
                txt.BackColor = Color.Empty;
            }
        }
    }
}
