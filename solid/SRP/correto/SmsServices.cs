using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.SRP.correto
{
    public class SmsServices
    {
        public void sendSMS(int telefone, string message)
        {
            if(!(telefone == 0))
            {
                Console.WriteLine($"SMS: {message} - FROM: {telefone}");
            }
        }
    }
}
