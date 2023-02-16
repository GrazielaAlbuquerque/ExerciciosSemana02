// See https://aka.ms/new-console-template for more information

using Exercicio_02;

Console.WriteLine("Segue os dados para a Ficha de Inscrição para o torneio");

DateTime data = new DateTime (1994, 10, 24, 16,30,00);
FichaInscricao _dadosFicha = new FichaInscricao (01, "Graziela Albuquerque", data, true);
_dadosFicha.ImprimeInscricao();

/*fichaInscrição fichaInscrição = new fichaInscrição();
fichaInscrição.Nome = "Graziela Albuquerque";
fichaInscrição.DataNascimento = DateTime.Now;*/
