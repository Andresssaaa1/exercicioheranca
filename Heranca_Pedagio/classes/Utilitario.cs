using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Pedagio.classes
{
    internal class Utilitario:Veiculo
    {
        public Utilitario(string placa, int eixos, int tipo) 
            : base(placa, eixos, tipo)
        {
            CalcularPedagio();
        }

        public override void CalcularPedagio()
        {
            double taxa = 2;
            this.PrecoPedagio = (QtdEixos * 3.5) + ((QtdEixos * 3.5 )* (taxa/100.0)) ;
            CalcularDesconto();
        }
    }
}
