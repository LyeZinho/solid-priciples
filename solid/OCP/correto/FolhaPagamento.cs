using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.OCP.correto
{
    public interface IRemuneravel
    {
        public double remuneracao();
    }

    public class Estagio : IRemuneravel
    {
        public double remuneracao()
        {
            return 1000;
        }
    }

    public class Clt : IRemuneravel
    {
        public double remuneracao()
        {
            return 2000;
        }
    }

    public class FolhaPagamento
    {
        public double calcular(IRemuneravel contrato)
        {
            return contrato.remuneracao();
        }
    }
}
