using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    class VeiculoBasico
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public short Ano { get; set; }
 
        // metodos
        public virtual int TesteImpsoto()
        {
            bool reserva;
            string tipoCombustivel;

            return 300;
        }
    }
}
