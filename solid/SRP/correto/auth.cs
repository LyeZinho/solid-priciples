using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.SRP.correto
{
    public class auth
    {
        public bool authCPF(string cpf)
        {
            if (cpf.Length == 11)
            {
                return true;
            }
            else return false;
        }

        public bool authMAIL(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else return false;
        }
    }
}
