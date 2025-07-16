using ExemploFundamentos.Common.Interfaces;
using ExemploFundamentos.Common.Models;
using ExemploFundamentos.Models;

IPessoa a1 = new Aluno("Gabriel", "Afini", 20, 2267, 8.5);

IPessoa p1 = new Professor("Brenda", "Acioli", 25, 2222, 4000.20M);

a1.Apresentar();
Console.WriteLine("--------");
p1.Apresentar();

// Pessoa p1 = new Pessoa("Gabriel", "Santos Afini da Silva");

// Pessoa p2 = new Pessoa("Jose", "Andrade");

// Curso curso = new Curso();
// curso.Nome = "Ingles";
// curso.Alunos = new List<Pessoa>();

// curso.AdicionarAluno(p1);
// curso.AdicionarAluno(p2);
// curso.ListarAlunos();
// curso.RemoverAluno(p1);
// curso.ListarAlunos();