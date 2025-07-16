using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploFundamentos.Common.Models;

namespace ExemploFundamentos.Models
{
    public class Professor : Pessoa
    {
        /// <summary>
        /// Instancia de Professor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="idade"></param>
        /// <param name="id"></param>
        public Professor(string nome, string sobrenome, int idade, int id, decimal salario) : base(nome, sobrenome, idade, id)
        {
            Salario = salario;
        }

        public decimal Salario { get; set; }

        public override void Id(int value)
        {
            _id = value;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Sou professor e meu salario é {Salario}, siape {_id}");
        }
    }
}