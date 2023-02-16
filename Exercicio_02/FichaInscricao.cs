using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_02
{
    public class FichaInscricao
    {
        private int id;

        public string nome {get; set; }

        public DateTime dataNascimento {get; set; }

        public Boolean menorIdade {get; set; }

        public FichaInscricao (int Id, string Nome, DateTime DataNascimento, Boolean MenorIdade)
    {
        this.id = Id;
        this.nome = Nome;
        this.dataNascimento = DataNascimento;
        this.menorIdade = MenorIdade;        
   }
   public void ImprimeInscricao()
   {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Data de Nascimento: {dataNascimento}");
        if (menorIdade == true){
            Console.WriteLine("Maior de Idade.");
            }
            else {Console.WriteLine ("Menor de idade.");
            }
    }
    }
}