using ExemploFundamentos.Common.Models;
using ExemploFundamentos.Models;

Aluno a1 = new Aluno();
a1.Nome = "Gabriel";
a1.Idade = 20;
a1.Nota = 7;

Professor p1 = new Professor();
p1.Nome = "Brenda";
p1.Idade = 25;
p1.Salario = 4000.20M;

a1.Apresentar();
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