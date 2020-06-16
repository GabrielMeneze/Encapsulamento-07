using System;

namespace Encapsulamento_07
{
    class Program : Pagamento
    {
        static void Main(string[] args)
        {
           
            Produto produt = new Produto();
            Pagamento pagar = new Pagamento();

            System.Console.WriteLine("Deseja pagar com Cartão? ");
            string escolha = Console.ReadLine();

            System.Console.WriteLine("Digite novamente para confirmar resposta");
            string Cartao = Console.ReadLine();
             

            pagar.rscolha(Cartao, escolha);
            if(pagar.Token == true){
                System.Console.WriteLine("Pagamento será efetuado no cartão");

                System.Console.WriteLine("Digite o nome do Titular: ");
                string NomeDoTitular = Console.ReadLine();

                System.Console.WriteLine("Digite o numero do cartão: ");
                string NumeroDoCartao = Console.ReadLine();

                System.Console.WriteLine("Digite o numero do cartão: ");
                string DatadeVencimento = Console.ReadLine();

                System.Console.WriteLine("Digite o numero do cartão: ");
                string CodigoDeSeguranca = Console.ReadLine();
            }else if(pagar.Token == false){
                System.Console.WriteLine("Deseja pagar com boleto");
            }
        }
    }
}
