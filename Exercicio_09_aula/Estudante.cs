using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_09_aula
{
    public class Estudante
    {
        public string Materia {get; set; }
        public int Nota {get; set; }
        
        public Estudante(string materia, int nota) 
        {
            Materia = materia;
            Nota = nota;
        }

        public void ImprimirMaiorNota()
        {
            Console.WriteLine($"m")
        }
    }
}