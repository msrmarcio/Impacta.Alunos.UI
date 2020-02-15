using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impacta.Alunos.UI
{
    public partial class frmOrientacaoObjetos : Form
    {
        public frmOrientacaoObjetos()
        {
            InitializeComponent();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            // declarar e instanciar um objeto carro
            Carro carro = new Carro("MERCEDES-BENZ");

            // preencher as caracteristicas nas propriedades
            carro.Modelo = "Fiat";
            carro.Marca = txtNomeCarro.Text.Trim().ToUpper();
            carro.Ano = 2020;
            carro.TipoCombustivel = "Gasolina";
            carro.QtdeRoda = 4;
            carro.QtdePortas = 3;

            // após preencher vamos listar no listBox
            lstVeiculos.Items.Add("Modelo: " + carro.Modelo);
            lstVeiculos.Items.Add("Marca: " + carro.Marca);
            lstVeiculos.Items.Add("Ano " + carro.Ano);
            lstVeiculos.Items.Add("Tipo de Combustivel: " + carro.TipoCombustivel);
            lstVeiculos.Items.Add("Qtde. Rodas : " + carro.QtdeRoda);
            lstVeiculos.Items.Add("QTde. Portas: " + carro.QtdePortas);

            // vamos fazer funcionar nosso carro;            
            MessageBox.Show(carro.LigarMotor("BRUM BRUM BRUM"));
            MessageBox.Show(carro.Acelerar());
            MessageBox.Show(carro.Brecar());
            MessageBox.Show(carro.PararMotor("RUMMMMMMMMMMMMMMMMM"));
        }

        private void btnAviao_Click(object sender, EventArgs e)
        {
            Aviao aviao = new Aviao("737 MAX");

        }
    }
}
