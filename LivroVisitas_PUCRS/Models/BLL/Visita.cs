using System;
using System.Collections.Generic;
using System.Text;

namespace LivroVisitas.BLL
{
    public class Visita
    {
        private String nome;
        private String sobrenome;
        private String email;

        public Visita(string nome, string sobrenome, string email)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.email = email;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string value)
        {
            this.nome = value;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public void setSobrenome(string value)
        {
            this.sobrenome = value;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string value)
        {
            this.email = value;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nome: ");
            sb.Append(nome);
            sb.Append(" ");
            sb.Append(sobrenome);
            sb.Append("/ E-mail: ");
            sb.Append(email);
            return (sb.ToString());
        }
    }
}
