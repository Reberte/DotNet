
using ExemploExplorando.Models;
using System.Data;
using System.Globalization;
using Newtonsoft.Json;


//






//##### Desafios de Código Coding The Future Avanade lll




// DESAFIO 03 -  Descubra a Carta

/*
Desafio
Nesse desafio, você deverá criar um programa que permita ao usuário escolher o valor e o naipe de uma carta de baralho, e exibir a carta escolhida.

Para isso, será necessário criar uma classe chamada Carta, que possua dois atributos: naipe e valor. Os valores de naipe e valor devem ser definidos como enumerações, para facilitar a escolha do usuário.

Como observação, os valores do enum Valor são:

Ás = 1; Valete = 2; Dama = 3; Rei = 4.
Já os valores do enum Naipe são :

Paus = 0; Ouros = 1; Copas = 2; Espadas = 3.
O programa deve permitir que o usuário escolha o valor e o naipe da carta, e em seguida criar uma instância da classe Carta com os valores escolhidos. Por fim, o programa deve exibir a carta escolhida, mostrando tanto o valor quanto o naipe da carta.

Requisitos:

Utilizar a classe "Carta" que possui dois atributos: "naipe" e "valor", ambos são enums.
Utilizar switch case para tratar exceções ao escolher o naipe e o valor da carta.
O programa deve permitir que o usuário escolha o naipe e o valor da carta.
O programa deve exibir a carta escolhida pelo usuário.
Entrada:
A entrada deve receber duas informações, referentes ao valor e naípe, conforme exemplo abaixo:

valor: Enum  - representando o valor da carta;
naipe: Enum  - representando o náipe da carta.
Saída:
O código deverá retornar uma mensagem (string) informando qual o valor da carta e seu náipe, após receber como entrada os Enums valor e naipe. Veja as entradas recebida abaixo:

3
2

De acordo com esses valores de entrada, a saída ficará desta maneira:

Carta escolhida: Dama de Copas

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
1
0	Carta escolhida: Ás de Paus
3
2	Carta escolhida: Dama de Copas
4
3	Carta escolhida: Rei de Espadas


using System;

public enum Naipe { Paus = 0, Ouros = 1, Copas = 2, Espadas = 3 }
public enum Valor { As = 1, Valete = 2, Dama = 3, Rei = 4 }

public class Carta
{
    private Naipe naipe;
    private Valor valor;

    public Carta(Naipe n, Valor v)
    {
        naipe = n;
        valor = v;
    }

    public Naipe GetNaipe()
    {
        return naipe;
    }

    public Valor GetValor()
    {
        //TODO: Implemente o GetValor();
        return valor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input para escolher a carta desejada
        int valorEscolhido, naipeEscolhido;
        do
        {
 
            valorEscolhido = int.Parse(Console.ReadLine());
        } while (valorEscolhido < 1 || valorEscolhido > 4);

        do
        {

            naipeEscolhido = int.Parse(Console.ReadLine());
        } while (naipeEscolhido < 0 || naipeEscolhido > 3);

        // Criação da carta escolhida pelo usuário
        Carta cartaEscolhida = new Carta((Naipe)naipeEscolhido, (Valor)valorEscolhido);

        // Exibição da carta escolhida pelo usuário
        string nomeValor = "", nomeNaipe = "";

        switch (cartaEscolhida.GetValor())
        {
            case Valor.As:
                nomeValor = "Ás";
                break;
            case Valor.Valete:
                nomeValor = "Valete";
                break;
            case Valor.Dama:
                nomeValor = "Dama";
                break;
            case Valor.Rei:
                nomeValor = "Rei";
                break;
        }

        switch (cartaEscolhida.GetNaipe())
        {
            case Naipe.Paus:
                nomeNaipe = "Paus";
                break;
            case Naipe.Ouros:
                nomeNaipe = "Ouros";
                break;
            //TODO: Complete o código
            case Naipe.Copas:
                nomeNaipe = "Copas";
                break;
            case Naipe.Espadas:
              nomeNaipe = "Espadas";
              break;
        }

        Console.WriteLine($"Carta escolhida: {nomeValor} de {nomeNaipe}");
    }
}


*/










// DESAFIO 02 - Construindo um Exército de Robôs


/*
Desafio
Você é um inventor de robôs excêntrico e engraçado, que decidiu criar seu próprio exército de robôs para ajudá-lo em suas tarefas diárias. Para isso, você precisa desenvolver uma classe Robô que permita que cada um dos seus robôs tenha características únicas. Crie seu próprio robô personalizado, escolhendo seu nome, modelo e ano de fabricação, e veja seu exército de robôs engraçados tomar forma diante dos seus olhos!

Você precisa criar uma classe Robo que possua um construtor que inicialize a classe com as características do robô (nome, modelo e ano de fabricação). Além disso, você precisa implementar métodos para exibir as características do robô.

Escreva uma classe Robo, que possua os seguintes atributos e métodos:

Três atributos: nome, modelo e ano de fabricação;
Construtor: deverá inicializar a classe com o nome, modelo e ano de fabricação;
Método chamado exibirInformações: que não receba parâmetros e exiba na tela as características do robô.
Seu programa deve solicitar ao usuário o nome, modelo e ano de fabricação do robô e criar um objeto Robo com essas informações. Em seguida, deve chamar o método exibirInformacoes para exibir as características do robô.

Entrada:
A entrada deverá receber os atributos do robô, conforme exemplo abaixo:

nome: referente ao nome do robô (string).
modelo: referente ao modelo do robô (string).
ano: referente ao ano da criação do robô (int).
IMPORTANTE: A entrada deverá seguir a ordem informada acima.

Saída:
O código deverá retornar uma mensagem (string) informando o nome, modelo e ano do robô criado, de acordo com o que foi recebido como entrada. Veja como exemplo a entrada recebida abaixo:

DioBot
DIO
2020

De acordo com esses valores de entrada, a saída ficará desta maneira:

O robô DioBOT, modelo DIO, foi fabricado em 2020.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Robozão
RBZ1000
2022
O robô Robozão, modelo RBZ1000, foi fabricado em 2022.
DioBot
DIO
2020
O robô DioBot, modelo DIO, foi fabricado em 2020.
Megazord
PR-2000
2017
O robô Megazord, modelo PR-2000, foi fabricado em 2017.



using System;

public class Robo
{
    private string nome;
    private string modelo;
    private int anoFabricacao;

    public Robo(string nome, string modelo, int anoFabricacao)
    {
        this.nome = nome;
        this.modelo = modelo;
        this.anoFabricacao = anoFabricacao;
    }

    public void ExibirInformacoes()
    {
        //TODO: Imprimir as informações de acordo com o enunciado deste desafio.
        Console.WriteLine($"O robô {nome}, modelo {modelo}, foi fabricado em {anoFabricacao}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nome, modelo;
        int ano;


        nome = Console.ReadLine();


        modelo = Console.ReadLine();

        ano = int.Parse(Console.ReadLine());

  //TODO: Instanciar um Robo passando os valores lidos em seu construtor.
  Robo r1 = new Robo(nome, modelo, ano);
  
  //TODO: Invocar o método "exibirInformacoes".
  r1.ExibirInformacoes();
    }
}


*/






/*
// DESAFIO 01 - Item Mágico!

Desafio
Em jogos de RPG, os jogadores frequentemente adquirem itens mágicos que possuem poderes e habilidades especiais. Neste desafio, você deve criar uma classe "ItemMagico" que represente um item mágico e seja capaz de armazenar o nome, descrição e poder do item.

Crie a classe "ItemMagico" que possua os seguintes atributos: "nome", "descricao" e "poder". Além disso, a classe deve ter um método chamado "criar", que recebe como argumento os valores do nome, descrição e poder do item, respectivamente.

Entrada
A entrada será dada pela chamada do método "criar" da classe "ItemMagico", utilizando o io.read() para obter os valores dos atributos de cada item:

nome: nome do item
descricao: descrição do item
poder: poder do item
Importante: a entrada deverá ocorrer de acordo com a ordem das informações fornecidas acima.

Saída
A saída deverá ser a impressão das informações do item criado, no formato:

Nome: [nome do item]
Descrição: [descrição do item]
Poder: [poder]
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Espada Flamejante
Uma espada de fogo!
50

Nome: Espada Flamejante
Descrição: Uma espada de fogo!
Poder: 50
Anel Mágico
Deixa o usuário invisível
5

Item: Anel Mágico
Descrição: Deixa o usuário invisível!
Poder: 5
Varinha Gelada
Congela até pensamentos
8

Item: Varinha Gelada
Descrição: Congela até pensamentos
Poder: 8



using System;

public class ItemMagico
{
    //TODO:  Crie a classe ItemMagico com os atributos nome, descrição e poder
    
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Poder { get; set; }
    

    public ItemMagico(string nome, string descricao, int poder)
    {
        Nome = nome;
        Descricao = descricao;
        Poder = poder;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Recebe a entrada do usuário

        string nome = Console.ReadLine();


        string descricao = Console.ReadLine();


        int poder = int.Parse(Console.ReadLine());

        // Cria o item mágico
        ItemMagico item = new ItemMagico(nome, descricao, poder);

        // Imprime o item criado
        Console.WriteLine($"Item: {item.Nome}\nDescrição: {item.Descricao}\nPoder: {item.Poder}");
    }
}


*/





/*


//Serializar e Deserializar


//Deserializar pegar o Json e transformar em Objeto

string consteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(consteudoArquivo);

foreach (Venda venda in listaVenda)
{
  Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
                    $" Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}


*/


/*//Serializar Gerar um aquivo Json
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

//string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
//Criando um arquivo .json
File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);

//Data padrçao ISO 8601
*/








/*

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



*/


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