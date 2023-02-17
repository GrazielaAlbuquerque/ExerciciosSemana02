using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_08
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}

        public void MostraIdade(){
            int idade = CalcularIdade();
            Console.WriteLine($"Nome {Nome} e tem {DataNascimento} anos");
        } 
      
    private int CalcularIdade(){
        var dataAtual = DateTime.Now;
        var idade = dataAtual.Year - DataNascimento.Year;
        if (DataNascimento > dataAtual.AddYears(-idade))
        {
    idade--;
    }
    return idade;
}       
        }

    }
