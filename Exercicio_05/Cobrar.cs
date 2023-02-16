using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_05
{
    public class Cobrar
    {
        private decimal Valor;
        private decimal Multa;
    public Cobrar(decimal valor, decimal multa) 
    {
        this.Valor = valor;
        this.Multa = valor;
    }

    private decimal CalcularMulta()
    {
        decimal SomaValor = (Valor = Multa);
        return SomaValor;
    }
    public Calcular ()
    {
        decimal Calcular = (Valor = Multa);
        Calcular = Console.WriteLine($"Valor Cobrado {Valor}, Multa {Multa}, Soma Valor {SomaValor}");
    }
    
    }
}

/*Detalhes da classe

Propriedades com modificador privado
Valor tipo decimal
Multa tipo decimal
Criar um construtor que vai preencher as propriedades privadas
Criar uma função privada chamada CalcularMulta que retorne o cálculo do Valor + Multa
Criar método público chamado Calcular
Esse método vai chamar um outra função chamada CalcularMulta
Mostrar a mensagem “Valor Cobrado {Valor}, Multa {Multa}, Soma Valor {SomaValor}
Instanciar a classe no console conforme mostrado em aula*/