using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.SRP.errado
{
    public class cliente
    {
        private string nome { get; set; }
        private string cpf { get; set; }
        private string endereco { get; set; }
        private string telefone { get; set; }
        private string email { get; set; }

        cliente()
        {
            this.nome = "";
            this.cpf = "";
            this.endereco = "";
            this.telefone = "";
            this.email = "";
        }

        public void cadastrarCliente(string nome, string cpf, string endereco, string telefone, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }

        public void atualizarCliente(string nome, string cpf, string endereco, string telefone, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }

        public bool autentiarCliente(string cpf)
        {
            if (cpf.Length == 11 && !(cpf == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sendMail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sendSMS(string telefone)
        {
            if (telefone.Length == 11 && !(telefone == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
