using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploFundamentos.Common.Models;

namespace ExemploFundamentos.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Sou aluno e minha nota é {Nota}");
        }
    }
}