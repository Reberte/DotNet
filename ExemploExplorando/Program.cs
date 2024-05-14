
using ExemploExplorando.Models;
using System.Data;
using System.Globalization;


///LENDO ARUIVO DE TEXTO
///
// try executa o código com cautela, se tiver erro o catch pega e cria uma exceção com o Exception 
try{ 
  string[] linhas = File.ReadAllLines("Arquivos/aarquivoLeitura.txt");

 foreach(string linha in linhas)
 {
  Console.WriteLine(linha);
 }
}catch(Exception ex)
{
  Console.WriteLine($"Ocorreu um erro na leitura do arquivo {ex.Message}");
}

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