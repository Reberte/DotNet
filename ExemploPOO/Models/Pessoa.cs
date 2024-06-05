using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {

        public Pessoa(){
            
        }
        //Construtir Pessoa
        public Pessoa(string nome){
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        //usando a palavra virtual, as classes filhas que utilizarem este metado Apresentar, pode alterar conforme a necessidade
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e minha idade é {Idade}!");
        }
    }
}