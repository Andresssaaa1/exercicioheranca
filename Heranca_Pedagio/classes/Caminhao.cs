using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Pedagio.classes
{
    internal class Caminhao:Veiculo
    {
        public Caminhao(string placa, int eixos, int tipo) 
            : base(placa, eixos, tipo)
        {
            CalcularPedagio();
        }

        public override void CalcularPedagio()
        {
            double taxa = 10;
            this.PrecoPedagio = (QtdEixos * 7)+((QtdEixos * 7)* (taxa/100));
            CalcularDesconto();
        }
    }
}
