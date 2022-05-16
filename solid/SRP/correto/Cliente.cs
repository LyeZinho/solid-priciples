using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.SRP.correto
{
    public class Cliente
    {
        private string nome { get; set; }
        private string cpf { get; set; }
        private string endereco { get; set; }
        private int telefone { get; set; }
        private string email { get; set; }

        public Cliente(string nome, string cpf, string endereco, int telefone, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }
    }
}
