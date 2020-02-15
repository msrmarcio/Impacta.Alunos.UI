using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Impacta.Alunos.UI
{
    public partial class frmListaClientes : Form
    { 

        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            //Limpar os dados da listbox
            lstLista.Items.Clear();
            //Definir a variável endereco
            string endereco = @"C:\Dados\ArquivoClientes.txt";

            try
            {
                ExisteDiretorio(endereco);

                //Definir um array do tipo string de 4 posições
                string[] dados = new string[4];

                //Definir o objeto StreamReader
                System.IO.StreamReader leitor = CriaObjeto_StreamReader(endereco);

                //Definir o cabeçalho na ListBox
                lstLista.Items.Add
                (
                    "CÓDIGO".PadRight(15) +
                    "CLIENTE".PadRight(30) +
                    "CIDADE".PadRight(20) +
                    "PAÍS"
                );
                CriaLinhaDelimitacao(80);

                //Ler os dados enquanto o arquivo não acabar
                dados = LeArquivo(dados, leitor);

                //Fechar o acesso ao arquivo de texto
                leitor.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ExisteDiretorios(string endereco)
        {
            if (!System.IO.File.Exists(endereco))
            {
                throw new Exception(
                "ArquivoClientes.txt não foi localizado!!");
            }
        }

        private void CriaLinhaDelimitacao(int qtde)
        {
            lstLista.Items.Add(new string('-', qtde));
        }

        private string[] LeArquivo(string[] dados, System.IO.StreamReader leitor, string tipoArquivo = "clientes")
        {
            string[] nomes_2 = new string[10];
            
            

            //TODO fazer semana que vem

            while (!leitor.EndOfStream)
            {
                //A instrução split desmonta a linha de registro nos
                //pontos e vírgulas e entrega nas respectivas
                //posições do array
                dados = leitor.ReadLine().Split(';');
                //Exibir os dados na lista com largura fixa,
                //preenchendo com espaços em branco à direita
                if (tipoArquivo == "clientes")
                {
                    //Exibir os dados na lista com largura fixa,
                    //preenchendo com espaços em branco à direita
                    lstLista.Items.Add
                    (
                    dados[0].PadRight(7) +
                    dados[1].PadRight(40) +
                    dados[2].PadRight(20) +
                    dados[3]
                    );
                }
                else
                {
                    lstLista.Items.Add
                    (
                    dados[0].PadRight(15) +
                    dados[1].PadRight(15) +
                    dados[2].PadRight(15) +
                    dados[3].PadRight(15) +
                    dados[4].PadRight(15) +
                    dados[5].PadRight(15) +
                    dados[6].PadRight(15) +
                    dados[7].PadRight(15) +
                    dados[8].PadRight(15) +
                    dados[9].PadRight(15) +
                    dados[10]
                    );

                }

            }

            return dados;
        }

        private static System.IO.StreamReader CriaObjeto_StreamReader(string endereco)
        {
            return new System.IO.StreamReader
            (
                endereco
            );
        }

        private static void ExisteDiretorio(string endereco)
        {
            if (!System.IO.File.Exists(endereco))
            {
                throw new Exception("ArquivoClientes.txt não foi localizado!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpar os dados da listbox
            lstLista.Items.Clear();
            //Definir a variável endereco
            string endereco = @"C:\Marcio\Cadastro de Veículos.txt";

            try
            {
                ExisteDiretorio(endereco);

                //Definir um array do tipo string de 4 posições
                string[] dados = new string[11];

                //Definir o objeto StreamReader
                System.IO.StreamReader leitor = CriaObjeto_StreamReader(endereco);

                CriaLinhaDelimitacao(170);

                //Ler os dados enquanto o arquivo não acabar
                dados = LeArquivo(dados, leitor, "Veiculo");
                //Fechar o acesso ao arquivo de texto
                leitor.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
