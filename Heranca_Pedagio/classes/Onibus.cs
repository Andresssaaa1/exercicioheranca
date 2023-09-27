using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Pedagio.classes
{
    internal class Onibus:Veiculo
    {
        public Onibus(string placa, int eixos, int tipo) 
            : base(placa, eixos, tipo)
        {
            CalcularPedagio();
        }

        public override void CalcularPedagio()
        {
            double taxa = 5;
            this.PrecoPedagio = (QtdEixos * 5) + ((QtdEixos * 5) * (taxa / 100));
            CalcularDesconto();
        }
    }
}
