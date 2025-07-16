using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploFundamentos.Common.Models;

namespace ExemploFundamentos.Models
{
    public class Aluno : Pessoa
    {
        /// <summary>
        /// Instancia de Aluno
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="idade"></param>
        /// <param name="id"></param>
        public Aluno(string nome, string sobrenome, int idade, int id, double nota) : base(nome, sobrenome, idade, id)
        {
            Nota = nota;
        }

        public double Nota { get; set; }

        public override void Id(int value)
        {
            _id = value;
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Sou aluno e minha nota é {Nota}, RA: {_id}");
        }
    }
}