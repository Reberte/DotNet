using System.Diagnostics.Contracts;
using ExemploFundamentos.Common.Models;






















/*
//#### Desafio de código Coding The Future Avanade I, desafio 02
Desafio
Em um jogo de RPG, os personagens geralmente possuem uma lista de itens que podem ser utilizados durante o jogo. Esses itens podem ser armas, armaduras, poções de cura, entre outros. É importante que o jogador tenha um controle desses itens para poder utilizá-los no momento adequado.

Crie um programa que permita cadastrar uma lista de itens que o personagem possui. A lista deve conter o valor fixo de 3 itens e deve ser exibida na tela.

Entrada
O programa deve solicitar ao usuário o nome dos 3 itens que o personagem possui. Cada item deve ser cadastrado separadamente.

Saída
Após receber os itens cadastrados pelo usuário, o programa deve exibir na tela a lista de itens que o personagem possui. A saída deve ter o seguinte formato:

Lista de itens:
- [item1]
- [item2]
- [item3]


// Lista para armazenar os itens


        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
        for (int contadorItem = 0; contadorItem < 3; contadorItem++)
        {
            //string? item = Convert.ToString(Console.ReadLine());
            itens.Add(Convert.ToString(Console.ReadLine()));

        }

        // Exibe a lista de itens
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
*/
/*
//#### Desafio de código Coding The Future Avanade I, desafio 01
       Console.WriteLine("Digite o valor do Saldo Total da Conta:");
        int saldoTotal = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o valor que deseja Sacar:");
        int valorSaque = int.Parse(Console.ReadLine());
        
        //TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.
       if(saldoTotal >= valorSaque){
         int novoSaldo = saldoTotal - valorSaque;
         Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {novoSaldo}");
       }
       else
       {
         Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
       }

*/
//### Criando listas 

// List<string> listaString = new List<string>();

// listaString.Add("BA");
// listaString.Add("SP");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens da minha lista {listaString.Count} - Capacidade {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens da minha lista {listaString.Count} - Capacidade {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens da minha lista {listaString.Count} - Capacidade {listaString.Capacity}");

// listaString.Add("PR");
// listaString.Add("DF");
// listaString.Add("RO");
// listaString.Add("RS");
// listaString.Add("RN");

// Console.WriteLine($"Itens da minha lista {listaString.Count} - Capacidade {listaString.Capacity}");


// PERCORRENDO A LISTA COM FOR 
// Console.WriteLine("Percorrendo a lista com FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//   Console.WriteLine($"Posição  Nº {contador} - {listaString[contador]}");
// }


// // PERCORRENDO A LISTA COM FOREACH
// Console.WriteLine("Percorrendo a lista com FOREACH");

// int contadorLista = 0;

// foreach(string item in listaString)
// {
//  Console.WriteLine($"Posição Nº {contadorLista} - {item}");
//  contadorLista++;
// }



/*


//### ARRAY Vetor [] 

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 50;
arrayInteiros[2] = 30;
arrayInteiros[3] = 1;
//Console.Write($"{arrayInteiros[3]}");


// PERCORRENDO O ARRAY COM FOR 

Console.WriteLine("Percorrendo o Array com FOR");

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
  Console.WriteLine($"Posição Nº {contador} = {arrayInteiros[contador]}");
}


// Criando um Array arrayInteirosDobrado com o dobro do tamanho do arrayInteiros e copiar os dados para o array arrayInteirosDobrado
// criando um novo array com o dobro do tamanho do arrayInteiros
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

//Copiando os dados do arrayInteiros para arrayInterirosDobrado e informando que eu quero copiar todos os dados do arrayInteiros.
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Console.WriteLine("Percorrendo o arrayInteirosDobrado:");

int contadorNovoArray = 0;
foreach(int valorArray in arrayInteirosDobrado)
{
  Console.WriteLine($"Posição Nº {contadorNovoArray} = {valorArray}");
  contadorNovoArray++;
}



// Como aumenta a capacidade do array, ou diminuir.
//Array.Resize(ref arrayInteiros,  arrayInteiros.Length * 2); // dobrndo a capacidade do array

// PERCORRENDO O ARRAY COM FOREACH

Console.WriteLine("Percorrendo o Array com FOREACH");
int contadorForeach = 0;
foreach(int valor in  arrayInteiros)
{
  Console.WriteLine($"Posição Nº {contadorForeach} = {valor}");
  contadorForeach++;
}




*/


/*

//##### Criando um Menu de opções e acões com Do While e Switch Case

string? opcao;
bool exibirMenu = true;


while(exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção: ");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Buscar cliente");
  Console.WriteLine("3 - Apagar cliente");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch(opcao)
  {
    case "1":
    Console.WriteLine("Cadastro de cliente");
    break;
    case "2":
    Console.WriteLine("Busca de cliente");
    break;
    case "3":
    Console.WriteLine("Apagar cliente");
    break;
    case "4":
    Console.WriteLine("Encerrar");
    //Environment.Exit(0);
    exibirMenu = false;
    break;
  }
}

Console.WriteLine("Sai Do Menu");


*/

/*

//#### ESTRUTURA DE REPETICAO DO WHILE
 int soma = 0, numero = 0;

do 
{
   Console.WriteLine("Digite um número ou (0 - para parar)");
   numero = Convert.ToInt32(Console.ReadLine());
   soma += numero;
}
while(numero != 0);

Console.WriteLine($"O Total da Soma dos números digitados é: {soma}");

*/

/*
//#### ESTRUTURA DE REPETICAO WHILE

int numero = 5;
int contador = 0;

while(contador <= numero)
{
   Console.WriteLine($"{numero} x {contador} = {numero*contador}" );
   contador++;
}
*/

/*
//#### Estrutura de Repetição FOR

int numero = 5;

for(int contador = 0; contador <= 10; contador++)
{
  Console.WriteLine($"{numero} x {contador} = {numero*contador}" );
}
*/


/*
//#### CALCULADORA USANDO A CLASSE CALCULADORA ONDE TEM OS METADOS SOMA ADICCAO SUBTRACAO DIVISAO
Calculadora calc = new Calculadora();
calc.Somar(10 , 30);
calc.Subtrair(10,50);
calc.Multiplicar(2,5);
calc.Dividir(50,5);
calc.Potencia(2,2);
*/


/*
//### CONDICIONAL NOT ! Negar uma condição, a = true então !a -> false;
bool estaChovendo = false;
bool estaTarde    = false;


if(!estaChovendo && !estaTarde)
{
  Console.WriteLine("Hoje está um dia ensolarado ótimo para Surfar");
}
else
{
  Console.WriteLine("Agora não é uma boa hora para Surfar.");
}
*/

/*
//###CONDICIONAL AND E &&

bool possuiPresencaMinina = true;
double media = 7.5;

if (possuiPresencaMinina = true && media >= 7)
{
  Console.WriteLine("Aprovado!");
}
else
{
  Console.WriteLine("Reprovado!");
}

*/
/*//#### CONDICIONAL SWITCH CASE

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine()??"";

switch(letra)
{
  case "a":
  case "e":
  case "i":
  case "o":
  case "u":
  Console.WriteLine($"A letra {letra} é uma Vogal!");
  break;
  default:
  Console.WriteLine($"A letra {letra} Não é uma Vogal!");
  break;
}
*/



/*
//##### CONDICIONAL IF
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de Compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a Venda? {possivelVenda}");

if (possivelVenda)
{
  Console.WriteLine("Venda realizada com sucesso!");
}
else
{
  Console.WriteLine("Desculpe, não possível realizar compra, estoque inferir a quantidade de compra.");
}
*/

//-------------------
/*
int quantidadeEmEstoque = 10;
int quantidadeCompra = 11;

if (quantidadeEmEstoque >= quantidadeCompra)
{
  Console.WriteLine("Venda realizada com sucesso!");
}
else
{
  Console.WriteLine("Desculpe, não possível realizar compra, estoque inferir a quantidade de compra.");
}
*/
//####

/*
DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("yyyy/mm/dd"));
Console.WriteLine(dataAtual.ToString("dd/mm/yyyy"));

Console.WriteLine(dataAtual.ToString("dd/mm/yyyy HH:mm"));

dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(dataAtual);

*/

// string apresentacao = "Olá, seja bem vindo!";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da varável quantidade: " + quantidade);
// Console.WriteLine("Valor da varável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da varável preco: " + preco);
// Console.WriteLine("Valor da varável condicao: " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Marcos";
// pessoa1.Idade = 36;
// pessoa1.Apresentar();
