using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.OCP.errado
{
    public class contratoClt
    {
        public double salario() { return 10.00; }
    }
    
    public class estagio
    {
        public double bolsaAuxilio() { return 5.00; }
    }

    public class FolhaPagamento
    {
        private double saldo;

        public double calcular( string contrato )
        {
            estagio est = new estagio();
            contratoClt clt = new contratoClt();

            if (contrato.Equals("estagio")) 
            {
                return est.bolsaAuxilio();
            } 
            else if(contrato.Equals("clt"))
            {
                return clt.salario();
            }
            else
            {
                return 0;
            }
        }
    }
}
