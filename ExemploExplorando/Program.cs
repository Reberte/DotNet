
using ExemploExplorando.Models;



Pessoa p1 = new Pessoa(nome:"Marcos",sobrenome:"Reberte");

Pessoa p2 = new Pessoa("Rafael","Filho");



/*
Pessoa p1 = new Pessoa();
p1.Nome = "marcos";
p1.Sobrenome = "reberte";
// p1.Idade = 36;
// p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Rafael";
p2.Sobrenome = "Filho";
*/

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();


