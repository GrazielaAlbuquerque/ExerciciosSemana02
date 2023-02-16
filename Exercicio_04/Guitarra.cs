using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_04
{
    public class Guitarra
    {
        private static string Afinacao {get; set;}

        static Guitarra()
        {
            Afinacao = "SOL"; 
        }
        private static void TomAfinado()
        {
            Console.WriteLine($"A guitarra está com afinação em {Afinacao}");
        }

        public void Tocar()
        {
            TomAfinado();
        }
        public void Tocar(string afinacaoAtual)
        {
            Afinacao = afinacaoAtual;
            TomAfinado();
        }
}
}