using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ExemploFundamentos.Common.Interfaces;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public abstract class Pessoa : IPessoa
    {
        public Pessoa(string nome, string sobrenome, int idade, int id)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Id(id);
        }

        private string _nome = "";
        private string _sobrenome = "";
        private int _idade;
        protected int _id;

        public string Nome
        {
            get => _nome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Sobreome não pode ser vazio");
                }

                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero.");
                }

                _idade = value;
            }
        }

        public abstract void Id(int value);

        /// <summary>
        /// Faz a pessoa se apresentar, dizendo nome e idade
        /// </summary>
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {NomeCompleto} e tenho {Idade} anos!");
        }
    }
}