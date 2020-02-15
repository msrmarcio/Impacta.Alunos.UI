using System;
using System.Windows.Forms;

namespace Impacta.alunos.UI
{
    public partial class FrmCadastroVeiculo : Form
    {
        public FrmCadastroVeiculo()
        {
            InitializeComponent();
        }

        private void FrmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            //Carregar combustivelCmbBox
            combustivelCmbBox.DataSource = Enum.GetNames(typeof(Combustiveis));

            //Desmarcar a combo
            combustivelCmbBox.SelectedIndex = -1;

            //Carregar cambioComboBox
            cambioCmbBox.DataSource = Enum.GetNames(typeof(Cambios));

            //Desmarcar a combo
            cambioCmbBox.SelectedIndex = -1;

            //Carregar marcaComboBox

            //Limpar dados anteriores
            marcaCmbBox.Items.Clear();

            //Utilizar o endereço onde o arquivo Marcas.txt foi gravado
            System.IO.StreamReader leitor =
                new System.IO.StreamReader(@"C:\Marcio\Marcas.txt");
            while (!leitor.EndOfStream)
            {
                marcaCmbBox.Items.Add(leitor.ReadLine());
            }
            leitor.Close();
             
        }

        private void GravarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo carro = new Veiculo(@"C:\Marcio\Cadastro de Veículos.txt");
                //Atribuir Valor as propriedades do veiculo
                //com as devidas validações
                carro.Placa = placaTxtBox.ValidarVazio().ValidarPlaca();
                carro.Modelo = modeloTxtBox.ValidarVazio();
                carro.Cor = corTxtBox.ValidarVazio();
                carro.Ano = anoTxtBox.ValidarInt16().ValidarAno();
                carro.Marca = marcaCmbBox.ValidarCombo();
                carro.Observacao = obsevacaoTxtBox.Text;

                //Fazendo CAST
                carro.Combustivel = (Combustiveis)combustivelCmbBox.ValidarComboEnum();

                //Fazendo CAST
                carro.Cambio = (Cambios)cambioCmbBox.ValidarComboEnum();

                //Chamar o método gravar do veículo
                carro.Gravar();

                //Avisar o usuário
                MessageBox.Show("Veículo gravado com sucesso!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Redefinir a tela
                this.LimparTela();
                placaTxtBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void obsevacaoTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toqueLbl.Text =
                    "Restante: " +
                    (300 - obsevacaoTxtBox.TextLength).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCadastroVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Passar a propriedade KeyPreview do formulário para TRUE
            if (e.KeyChar == 27)
            {
                this.LimparTela();
            }
        }
    }
}
