using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.SRP.correto
{
    public class MailServices
    {
        public void sendMail(string destiny_email, string message)
        {
            auth auth = new auth();
            if (auth.authMAIL(destiny_email))
            {
                Console.WriteLine($"MAIL: {message}, - From: {destiny_email}");
            }
        }
    }
}
