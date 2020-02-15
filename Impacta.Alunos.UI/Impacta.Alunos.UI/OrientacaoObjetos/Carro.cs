using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    // para aplicar a herança devemos utilizar o sinal :
    // a classe que será herdada, deve estar com modificador
    // de acesso como  public
    public class Carro : Veiculo, ICarro, ICadastro
    {
        #region PROPRIEDADES
        // Boa prática nomear as propriedades com 
        // inicio com letra maiuscula
        // code snippet - prop seguido de TAB TAB
        // -> isso cria a nossa propriedade AUTOMATICA
        public int QtdePortas { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #region EXPLICACAO PROPRIEDADE COMPLETA
        // code snippet - propfull seguido de TAB TAB
        // -> isso cria a nossa propriedade COMPLETA
        //private int qtdePortas;
        //public int QtdePortas
        //{
        //    get { return qtdePortas; }

        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new Exception("Não é permitido valor Negativo para QtdePortas");
        //        }

        //        qtdePortas = value;
        //    }
        //}
        #endregion
        #endregion

        /// <summary>
        /// Metodo construtor
        /// </summary>
        /// <param name="nomeModelo">Nome do modelo do carro</param>
        //public Carro(string nomeModelo)
        //{
        //    this.Modelo = nomeModelo;
        //}

        // este metodo construtor repassa para a classe BASE
        // o conteudo recebido no parametro nomeModelo
        public Carro(string nomeModelo) : base(nomeModelo)
        {
            
        }




        #region METODOS

        public string Acelerar()
        {
            return "Acelerando....VRUM VRUM VRUM";
        }

        public string Brecar()
        {
            return "Parando.....";
        }

        public override string Drive()
        {
            return "Dirigindo Automovel";
        }

        public bool SalvarRegistro()
        {
            throw new NotImplementedException();
        }

        public bool DeleteRegistro()
        {
            throw new NotImplementedException();
        }

        public Carro ConsultarTodosVeiculos()
        {
            
            throw new NotImplementedException();
        }

        public int BuscaIdRegistro(int nomeVeiculos)
        {
            throw new NotImplementedException();
        }

        public bool CadastrarVeiculo()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
