using System.Diagnostics.Contracts;
using ExemploFundamentos.Common.Models;








//####### Desafios de Código Coding The Future Avanade ll #######






// DESAFIO 03

/*

Desafio
Você está trabalhando para uma empresa que utiliza extensivamente os serviços da AWS, e após algumas análises a equipe de segurança identificou que algumas senhas dos usuários no IAM são fracas e podem representar um risco à segurança dos dados da empresa. Para resolver esse problema, foi solicitado que você desenvolva um programa capaz de analisar as senhas dos usuários e fornecer uma validação de força com base em critérios predefinidos.

Requisitos de segurança para a senha:

A senha deve ter no mínimo 8 caracteres.
A senha deve conter pelo menos uma letra maiúscula (A-Z).
A senha deve conter pelo menos uma letra minúscula (a-z).
A senha deve conter pelo menos um número (0-9).
A senha deve conter pelo menos um caractere especial, como !, @, #, $, %, etc.
Entrada
A entrada será uma única string representando a senha que precisa ser validada.

Saída
Seu programa deve retornar uma mensagem indicando se a senha fornecida pelo usuário atende aos requisitos de segurança ou não, juntamente com um feedback explicativo sobre os critérios considerados.

Entrada	Saída
0101	Sua senha e muito curta. Recomenda-se no minimo 8 caracteres.
030609saturno*	Sua senha atende aos requisitos de seguranca. Parabens!
010203Jupiter	Sua senha nao atende aos requisitos de seguranca.





using System;
using System.Linq;

class Program
{
    static string VerificarForcaSenha(string senha)
    {
        int comprimentoMinimo = 8;
        bool temLetraMaiuscula = false;
        bool temLetraMinuscula = false;
        bool temNumero = false;
        bool temCaractereEspecial = false;

        // TODO: Verifique o comprimento da senha
        if (senha.Length < comprimentoMinimo)
         return "Sua senha e muito curta. Recomenda-se no minimo 8 caracteres.";

        // Verificando se a senha contém letras maiúsculas e minúsculas
        temLetraMaiuscula = senha.Any(char.IsUpper);
        temLetraMinuscula = senha.Any(char.IsLower);

        // Verificando se a senha contém sequências comuns
        string[] sequenciasComuns = { "123456", "abcdef" };
        if (sequenciasComuns.Any(s => senha.Contains(s)))
            return "Sua senha contem uma sequencia comum. Tente uma senha mais complexa.";

        // Verificando se a senha contém palavras comuns
        string[] palavrasComuns = { "password", "123456", "qwerty" };
        if (palavrasComuns.Contains(senha))
            return "Sua senha e muito comum. Tente uma senha mais complexa.";

        // Verificando se a senha contém números e caracteres especiais
        temNumero = senha.Any(char.IsDigit);
        temCaractereEspecial = senha.Any(c => !char.IsLetterOrDigit(c));

        if (temLetraMinuscula && temLetraMaiuscula && temNumero && temCaractereEspecial)
            return "Sua senha atende aos requisitos de seguranca. Parabens!";
        else
            return "Sua senha nao atende aos requisitos de seguranca.";
    }

    static void Main(string[] args)
    {
        string senha = Console.ReadLine().Trim();

        string resultado = VerificarForcaSenha(senha);

        Console.WriteLine(resultado);
    }
}

*/













// DESAFIO 02


/*
Desafio
Em jogos de RPG, os personagens possuem atributos que determinam suas habilidades em diferentes áreas, como força, agilidade, inteligência, etc. Neste desafio, você deve criar uma função que verifica se o valor de um determinado atributo está dentro de um intervalo aceitável.

Crie uma função chamada "verificar_atributo" que recebe três parâmetros: "atributo", "valor_minimo" e "valor_maximo". A função deve verificar se o valor do atributo está dentro do intervalo definido pelos valores mínimo e máximo.
Caso o valor esteja dentro do intervalo, a função deve retornar true. Caso contrário, deve retornar false.

Entrada:
A entrada do código deverá ser feita através do io.stream(). Serão necessários três valores para chamar a função "verificar_atributo", que são: o nome do atributo, o valor mínimo aceitável e o valor máximo aceitável. Além disso, também será necessário informar o valor atual do atributo que se deseja verificar.

Saída:
A saída do código será uma mensagem informando se o valor do atributo está dentro ou fora do intervalo especificado. Caso o valor esteja dentro do intervalo, a mensagem será "O valor do atributo está dentro do intervalo especificado". Caso contrário, a mensagem será "O valor do atributo está fora do intervalo especificado".

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
força
1
10
7

O valor do atributo está dentro do intervalo especificado
destreza
6
12
3

O valor do atributo está fora do intervalo especificado
inteligencia
1
100
94

O valor do atributo está dentro do intervalo especificado




using System;

class Program
{
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {
      
        //TODO: Implemente a função VerificarAtributo
        return valorAtributo >= valorMinimo && valorAtributo <= valorMaximo;
       
    }

    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();

        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());

       bool res = VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo);
       
        
        
          if(res)
          {
            Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
            
          }
          else
          {
            Console.WriteLine("O valor do atributo está fora do intervalo especificado");
            
          }
        }
        
    }


*/






// DESAFIO 01
/* 
Desafio 01
Em jogos de RPG, é comum haver ações de ataque dos personagens, que causam um certo dano ao inimigo. Este dano pode ser calculado de diferentes formas, dependendo do sistema do jogo. Neste desafio, você deve criar uma função que calcula o dano de um ataque, levando em consideração o valor do ataque e a defesa do inimigo.

Crie uma função chamada "calcular_dano" que recebe dois parâmetros: "ataque" e "defesa". A função deve retornar o valor do dano causado pelo ataque, utilizando a seguinte fórmula:

dano = ataque - defesa

Se o valor do dano for negativo, ele deve ser considerado zero.

Entrada:
Seu programa deverá receber uma  entrada para a função "calcular_dano", que irá solicitar ao usuário que insira dois valores: o valor do ataque e o valor da defesa do inimigo. Esses valores serão passados como parâmetros para a função.

Saída:
A saída deve ser exibida com a frase "O dano causado pelo ataque foi: " seguida do valor do dano calculado. Caso o valor do dano seja negativo, deve ser exibido zero.

Por exemplo, se o valor do ataque for 10 e o valor da defesa do inimigo for 8, a chamada da função "calcular_dano" deve resultar na seguinte saída:

"O dano causado pelo ataque foi: 2"
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
10
8

O dano causado pelo ataque foi: 2
3
9

O dano causado pelo ataque foi: 0
7
1

O dano causado pelo ataque foi: 6




   using System;

class Program
{
    static int CalcularDano(int ataque, int defesa)
    {
        //TODO: Implemente a função calcular dano
        int dano = ataque - defesa;
        if(dano < 0)
        {
          dano = 0;
        }
        return dano;
    }

    static void Main(string[] args)
    {
        int ataque = int.Parse(Console.ReadLine());

        int defesa = int.Parse(Console.ReadLine());

        int danoCausado = CalcularDano(ataque, defesa);
        Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
    }
}
    

*/











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
