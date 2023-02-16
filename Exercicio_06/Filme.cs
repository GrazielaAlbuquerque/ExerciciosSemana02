using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_06
{
    public class Filme
    {
        public string NomeFilme { get; set;}
        public string CategoriaFilme { get; set;}
        {
            Console.WriteLine("O nome do filme de hoje é {nome}");
        }
        public static void Categoria(string categoria);
        {
            Console.WriteLine("Este filme é um(a) {categoria}");
            }
    }
}

/*Detalhes da classe

Propriedades
NomeFilme tipo string
Categoria tipo string
Criar uma função que retorne o nome do filme informado
Mensagem “Filme {Nome Filme}, Categoria {Categoria}
Instanciar a classe no console conforme mostrado em aula