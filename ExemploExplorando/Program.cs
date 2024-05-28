
using ExemploExplorando.Models;
using System.Data;
using System.Globalization;



// IF  TERNARIO 

int numero = 20;
bool ehPar = false;

// IF TERNÁRIO

ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));


/// if normal
// if (numero % 2 == 0)
// {
//   Console.WriteLine($"O número {numero} é par ");
// }
// else 
// {
//   Console.WriteLine($"O número {numero} é impar");
// }






/*
//Desconstrutor metodo criado na classe Pessoa
Pessoa p1 = new Pessoa("Marcos", "Reberte");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");

*/









/*

//TUPLA coleção de dados que pode armazenar varias dados de tipos diferentes
LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
  foreach(string linha in linhasArquivo)
  {
    Console.WriteLine(linha);
  }

}
else 
{
  Console.WriteLine("Não foi posível ler o arquivo");
}


*/

/*

//TUPLA coleção de dados que pode armazenar varias dados de tipos diferentes

//forma recomendada de declarar um Tupla
(int, string, string, decimal) tupla = (1, "Marcos", "Reberte", 10.5M);

//ValeuTuple<int, string, string, decimal> outroExemplo = (1, "Marcos", "Reberte", 10.5M);
//var outroExemploTuplaCreate = Tupla.Create(1, "Marcos", "Reberte", 10.5M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");



*/



/*

// Dictionary <chave, elemento> a chave deve ser unica, não pode ter repetido

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("------------------");

estados.Remove("BA"); // removendo Bahia informando a chave

estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("------------------");

string chave = "BA";

Console.WriteLine($"Verificando o elemento {chave}");

if (estados.ContainsKey(chave))
{
  Console.WriteLine($"Valor existente:  {chave}");
}
else
{
  Console.WriteLine($"Valor não existe. É seguro adicionar a chave:  {chave}");
}


// Consultando um estado

Console.WriteLine(estados["MG"]);


*/






/*
// Stack Pilha LIFO o O primeiro a entrar na pilha será o último a sair

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
  Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");

pilha.Push(20);

foreach(int item in pilha)
{
  Console.WriteLine(item);
}

*/






/*
// Queue FILA FIFO -> primeiro que entrar na fila de execução será o primeiro a sair da fila;

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);
fila.Enqueue(12);

foreach(int item in fila)
{
  Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");


foreach(int item in fila)
{
  Console.WriteLine(item);
}


*/







/*
// Usando throw -> tratando uma execeção

new ExemploExcecao().Metodo1();

*/









/*
///LENDO ARUIVO DE TEXTO
///
// try executa o código com cautela, se tiver erro o catch pega e cria uma exceção com o Exception 
//finally {} sempre será executado, dando erro ou não no código.

try{ 
  string[] linhas = File.ReadAllLines("Arquivoss/aarquivoLeitura.txt");

 foreach(string linha in linhas)
 {
  Console.WriteLine(linha);
 }
}
catch(FileNotFoundException ex)
{
  Console.WriteLine($"Ocorreu um erro na leitura do arquivo {ex.Message}");
}

catch(DirectoryNotFoundException ex)
{
  Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da Pasta não encontrado. " + ex.Message);
}

catch(Exception ex)
{
  Console.WriteLine($"Ocorreu exceção Genérica {ex.Message}");
}

finally
{
  Console.WriteLine("Chegou até aqui!");
}



*/









/*
//// MANIPULANDO E FORMATANDO DATAS

DateTime data = DateTime.Now;

Console.WriteLine(data);

//Formatando a data 
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

//Formato data curta
Console.WriteLine(data.ToShortDateString());

//Formato somente a hora
Console.WriteLine(data.ToShortTimeString());


//Formatando uma data que veio em uma padrão doferente da que eu quero
//Formato data curta
 data = DateTime.Parse("12/04/2024 18:00");

 Console.WriteLine(data);


Console.WriteLine("----- Convertendo data -----");
 string dataString = "2022-13-17 18:59";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataA);

if(sucesso)
{
  Console.WriteLine("Conversão feita com Sucesso!");
  Console.WriteLine(dataA);

}
else{
  Console.WriteLine($"Não foi possível efetuar a conversão, verifique a data informada! -> {dataString}");
}


*/

/*
//definando a cultura no sistema - Porugues Brasil
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
// Formatando valor em Real R$ usando Currence - pega a formatação do sistema operacional Portugues-Brasil
decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}");

//Formatando o valor manualmente pelo ToString
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));


Console.WriteLine(valorMonetario.ToString("N2"));

double porcentagem = .3421;
// formatando percentual
Console.WriteLine(porcentagem.ToString("P"));

int numero = 20240514;
// formatando separando digitos por -
Console.WriteLine(numero.ToString("####-##-##"));
*/
/*

Console.WriteLine();

*/





/*

string valor1 = "10";
string valor2 = "20";
string resultado = valor1 + valor2;

Console.WriteLine(resultado);


*/








/*
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
/*
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();


*/