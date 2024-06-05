using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {

       public Aluno()
       {
        
       }

        // Neste construtor é obrigatorio informar o nome
        public Aluno(string nome) : base(nome){

        }
        public double Nota { get; set; }
        public string Email { get; set; }

        // a palavra override está sobreescrevendo o metodo Apresentar()
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}