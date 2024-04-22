using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT7
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        /*Propiedades (get e set)
         é um controle de acesso ás variá´veis. */
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            //get = leitura
            get
            {
                return telefone;
                //set = escrita
            }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }

                else
                {
                    //País-Cidade-Telefone, ex: +55
                    telefone = "+00-00-0000-00000";
                }
                // O método que tem o mesmo nome da classe
                // e não retorna nada,é chamado CONSTRUTOR
                // DA CLASSE



            }
        }
        public Contato()
        {

            Nome = "Jóse";
            Sobrenome = "Da Silva";
            Telefone = "11-99999-9999";
        }
        public Contato(string nome, string sobrenome, string telefone)
        {

            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        // Sobrescrever o método ToString()
        // "polimorfismo" .

        public override string ToString()
        {
         
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += string.Format("+{0} {1}-{2}",
                Telefone.Substring(0, 2),
                Telefone.Substring(2, 5),
                Telefone.Substring(7, 4));
            return saida;
        }
    }
}


        }
  

 