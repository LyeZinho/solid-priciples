using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.ISP.correto
{
    public interface Aves
    {
        public void Voar();
        public void Nadar();
        public void Andar();
    }

    public class papagaio : Aves
    {
        public void Andar()
        {
            Console.WriteLine("Andando");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }

        public void Voar()
        {
            Console.WriteLine("Voando");
        }
    }

    public class penguin : Aves
    {
        /*
        Penguin não pode voar porem como 
        ele herda da interface aves ele
        é obrigado a implementar os métodos
        */
        public void Andar()
        {
            Console.WriteLine("Andando");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }

        public void Voar()
        {
            Console.WriteLine("Voando");
        }
    }
}
