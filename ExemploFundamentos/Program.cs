using ExemploFundamentos.Common.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Gabriel";
p1.Sobrenome = "Santos Afini da Silva";

Pessoa p2 = new Pessoa();
p2.Nome = "Jose";
p2.Sobrenome = "Andrade";

Curso curso = new Curso();
curso.Nome = "Ingles";
curso.Alunos = new List<Pessoa>();

curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);
curso.ListarAlunos();