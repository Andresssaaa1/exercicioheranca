using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Pedagio.classes
{
    internal class Passeio:Veiculo
    {
        public Passeio(string placa, int eixos, int tipo) 
            : base(placa, eixos, tipo)
        {
            CalcularPedagio();
        }

        public override void CalcularPedagio()
        {
            this.PrecoPedagio = QtdEixos * 3;
            CalcularDesconto();
        }
    }
}
