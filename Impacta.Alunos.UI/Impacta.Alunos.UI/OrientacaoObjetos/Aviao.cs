using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    public class Aviao : Veiculo, ICadastro
    {
        public int QtdeTripulantes { get; set; }
        public int QtdeSaidaEmergenica { get; set; }

        public Aviao(string nomeModelo) : base(nomeModelo)
        {

        }


        #region METODO
        public string Decolar()
        {
            return ("Decolando");
        }

        public string Aterrissar()
        {
            return ("Aterrissando");
        }

        public override string Drive()
        {
            return ("Voando");
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
