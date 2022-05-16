using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.DIP.errado
{
    public class MySQLconn
    {
        public void Open()
        {
            Console.WriteLine("MySQL connection opened");
        }

        public void Close()
        {
            Console.WriteLine("MySQL connection closed");
        }
    }

    public class passwordReminder
    {
        /*
        Desta forma o codigo está muito acoplado e isso gera muitas dependencias
        o que reduz a capacidade de manutenção do codigo.
        */
        MySQLconn conn = new MySQLconn();

        public void SendPassword(string email)
        {
            conn.Open();
            conn.Close();
        }
    }
}
