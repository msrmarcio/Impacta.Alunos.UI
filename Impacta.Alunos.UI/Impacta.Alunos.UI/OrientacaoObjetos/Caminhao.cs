using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI.OrientacaoObjetos
{
    public class Caminhao: Veiculo
    {
        public string TipoCarroceria { get; set; }
        public int ToraMaxima { get; set; }
        public string Tipo { get; set; }

        public Caminhao(string nomeModelo) : base(nomeModelo)
        {

        }

    }
}
