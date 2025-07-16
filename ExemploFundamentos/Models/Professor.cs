using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploFundamentos.Common.Models;

namespace ExemploFundamentos.Models
{
    public class Professor : Pessoa
    {
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