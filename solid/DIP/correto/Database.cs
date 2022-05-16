using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.DIP.correto
{

    public interface IDbConnection
    {
        void Open();
        void Close();
    }

    public class MySQLconn : IDbConnection
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

    public class SqlServerconn : IDbConnection
    {
        public void Open()
        {
            Console.WriteLine("SqlServer connection opened");
        }

        public void Close()
        {
            Console.WriteLine("SqlServer connection closed");
        }
    }

    public class PostgreSQLconn : IDbConnection
    {
        public void Open()
        {
            Console.WriteLine("PostgreSQL connection opened");
        }

        public void Close()
        {
            Console.WriteLine("PostgreSQL connection closed");
        }
    }

    public class passwordReminder
    {
        private IDbConnection? dbconn;

        public passwordReminder(IDbConnection? dbconn)
        {
            this.dbconn = dbconn;
        }

        /* Faz alguma coisa */
    }
}
