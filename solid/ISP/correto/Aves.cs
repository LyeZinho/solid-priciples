using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.ISP
{
    public interface Aves
    {
        public void Nadar();
        public void Andar();
    }
    public interface AvesQueVoam : Aves
    {
        public void Voar();
    }

    public class Penguin : Aves
    {
        public void Nadar()
        {
            Console.WriteLine("Penguin nadando");
        }
        public void Andar()
        {
            Console.WriteLine("Penguin andando");
        }
    }

    public class Papagaio : AvesQueVoam
    {
        public void Andar()
        {
            Console.WriteLine("Papagaio andando");
        }

        public void Nadar()
        {
            Console.WriteLine("Papagaio nadando");
        }

        public void Voar()
        {
            Console.WriteLine("Papagaio voando");
        }
    }
}
