using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_03
{
    public class MensagemCelular
    {
        public int telefone {get; set; }
        public string mensagem {get; set; }
        public MensagemCelular(int Telefone, string Mensagem)
        {
            this.telefone = Telefone;
            this.mensagem = Mensagem;
        }

        public void Executar()
        {
            Console.WriteLine("Método Executado pelo Console");
            EnviarMensagemAoTelefone();
        }

        private void EnviarMensagemAoTelefone ()
        {
         Console.WriteLine ("Método privado executado na classe") ;
         Console.WriteLine ("Telefone: {0}, Mensagem: {1}", telefone, mensagem);
        }
    }



}