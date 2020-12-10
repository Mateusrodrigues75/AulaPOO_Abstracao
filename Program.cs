using System;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            float precoProduto;
            int escolha;
            Console.WriteLine("Bem Vindo ao Sistema de Compra");

            Console.WriteLine("Digite o valor do Produto: ");
            precoProduto = float.Parse(Console.ReadLine());


            do
            {
            Console.WriteLine("Escolhe uma forma de Pagamento:\n[1] - Boleto\n[2] - Crédito\n[3] - Débito");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                
                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:

                    break;
            }
            } while (escolha !=0);
            
            
            


        }
    }
}
