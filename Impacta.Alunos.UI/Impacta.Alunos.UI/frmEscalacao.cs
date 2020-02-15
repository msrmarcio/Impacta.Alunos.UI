using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// importa as funcionalidades do VisualBasic.NET
using Microsoft.VisualBasic;


namespace Impacta.Alunos.UI
{
    public partial class frmEscalacao : Form
    {
        string[] arrNomeJogadores;

        public frmEscalacao()
        {
            InitializeComponent();


        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (arrNomeJogadores == null)
                {
                    // inicializamos o array, instanciando com o valor informado no form
                    arrNomeJogadores = new string[Convert.ToInt32(nupQtdeJogadores.Value)];
                }

                // verifica se o nome dos jogadores foram obtidos conforme a Qtde.
                if (ObtemNomeJogadores())
                {
                    // insere os jogadores cadastrados no ListBox
                    InsereNoListBox();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar a lista de nomes de jogadores: \n" + ex.Message,
                    "Impacta Tecnologia - Cadastro de jogadores",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InsereNoListBox()
        {
            // se atingiu o numero de jogadores, então colocamos no listBox
            // para adicionar no listbox utilizamos o metodos add
            // e para percorrer o array vamos utilizar o foreach
            for (int i = 0; i < arrNomeJogadores.Length; i++)
            {
                lstNomeJogadores.Items.Add(i + 1 + " - " + arrNomeJogadores[i]);
            }
        }

        private bool ObtemNomeJogadores()
        {
            for (int i = 0; i < arrNomeJogadores.Length; i++)
            {
                // aqui vamos utilizar o recurso do VB.Net InputBox
                // ele serve para aparecer um popup na tela com entrada de texto
                arrNomeJogadores[i] = Interaction.InputBox("Digite o nome do Jogador",
                                            "Impacta - Cadastro Jogadores");
            }

            // fazemos um IF TERNARIO (colocado entre parenteses) para validar se os nomes 
            // foram preenchidos ou não
            // se qtde de jogadores atingiu o numero desejado retorna true
            return (arrNomeJogadores.Count() >= nupQtdeJogadores.Value) ? true : false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // this referencia a classe atual, neste caso o nosso form
            this.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                // vamos verificar se o listbox esta com item selecionado
                // todo controle que é do tipo lista  ou collection 
                // qdo esta com -1, é pq ainda não foi selecionado ou
                // esta vazio
                if (lstNomeJogadores.SelectedIndex == -1)
                {
                    // vamos lançar uma Exception
                    throw new Exception("Nenhum item foi selecionado");
                }

                // vamos remover o item selecionado
                // pelo indice do item selecionado
                lstNomeJogadores.Items.RemoveAt(lstNomeJogadores.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Impacta Tecnologia - Informação",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTranferir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstNomeJogadores.Items.Count > 0 )
                {
                    foreach (var item in lstNomeJogadores.Items)
                    {
                        lstEscalados.Items.Add(item);
                    }

                    // limpa o ListBox
                    lstNomeJogadores.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Impacta Tecnologia - Informação",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
