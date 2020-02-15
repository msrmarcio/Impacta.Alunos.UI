using System;
using System.Collections;
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
    public partial class FrmSpider : Form
    {
        Queue fila = new Queue();

        public FrmSpider()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // criar um array list
            // nao preciso informar o tamanho 
            var arrItems = new ArrayList();

            for (int i = 0; i <= 10; i++)
            {
                //arrItems.Add(i);
                fila.Enqueue(i);
                lstItems.Items.Add(i);
            }

            // exemplo de como percorrer um ARRAYLIST
            //for (int i = 0; i < arrItems.Count; i++)
            //{
            //    //lstItems.Items.Add(arrItems[i]);                
            //}

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Remove o item da FILA
            lblDisplay.Text = fila.Dequeue().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // retorna o primeiro item da lista
            var item = fila.Peek().ToString();

            MessageBox.Show("Primeiro item da lista é: " + item);
        }
    }
}
