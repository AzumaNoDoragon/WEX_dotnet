using ExemploFundamentos.Common.Models;

Pessoa p1 = new Pessoa("Gabriel", "Santos Afini da Silva");

Pessoa p2 = new Pessoa("Jose", "Andrade");

Curso curso = new Curso();
curso.Nome = "Ingles";
curso.Alunos = new List<Pessoa>();

curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);
curso.ListarAlunos();
curso.RemoverAluno(p1);
curso.ListarAlunos();