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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        //Definir o método CalcularTabuada() aqui ...
        private void CalcularTabuada()
        {
            //Limpar a lista anterior
            lstTabuada.Items.Clear();
            int tabuada = Convert.ToInt32(txtTabuada.Text);
            //Calcular a tabuada
            for (int i = 0; i <= 10; i++)
            {
                lstTabuada.Items
                .Add(tabuada + " x " + i + " = " +
                (tabuada * i).ToString("#,##0"));
            }
            txtTabuada.Focus();
            txtTabuada.SelectAll();
        }

        //Definir o método LimparTela() aqui ...
        private void LimparTela()
        {
            txtTabuada.Clear();
            lstTabuada.Items.Clear();
            txtTabuada.Focus(); 
        }

        private void txtTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir apenas NÚMEROS, BACKSPACE e ENTER
            if (
            e.KeyChar >= '0' && e.KeyChar <= '9' ||
            e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                //Se a tecla pressionada for ENTER,
                //chamar o método CalcularTabuada()
                if (e.KeyChar == '\r')
                {
                    CalcularTabuada();
                }
            }
            else
            {
                //Caso não seja uma tecla válida,
                //anular a tecla digitada
                e.KeyChar = '\0';
            }
        }

        private void frmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            //A propriedade KeyPreview do formulário deve ser TRUE
            if (e.KeyChar == 27)
            {
                LimparTela();
            }
        }
    }
}
