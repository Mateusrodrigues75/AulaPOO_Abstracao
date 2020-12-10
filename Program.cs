using System;
using AulaPOO_Abstracao.classes;

namespace AulaPOO_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            float precoCompra;
            int escolha;
            Console.WriteLine("-----Bem Vindo ao Sistema de Compra-----");

            Console.WriteLine("Digite o valor do Produto: ");
            precoCompra = float.Parse(Console.ReadLine());


            do
            {
            Console.WriteLine("Escolha uma forma de Pagamento:\n[1] - Boleto -> 12% de Desconto\n[2] - Crédito\n[3] - Débito\n[0] - Sair da Aplicação");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                //boleto
                Boleto boleto = new Boleto();
                boleto.Valor = precoCompra;

                boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoDeBarras);
                    return;
                case 2:
                //Crédito
                Credito novoCredito = new Credito();
                novoCredito.SalvarCartao();
                Console.WriteLine("Crédito Selecionado...");
                Console.WriteLine("-----------------------");
                Console.WriteLine("O pagamento em Cartão de Crédito tem de 5% até 6 parcelas e 8% de 7 a 12 parcelas.\nATENÇÃO: O número máximo de Parcelas é 12!");
                int parcelas;
                Console.WriteLine("Digite o numero de Parcelas:");
                parcelas = int.Parse(Console.ReadLine());
                novoCredito.Parcelar(parcelas);
                if (novoCredito.Parcelar(parcelas) == false)
                {
                    Console.WriteLine("Número de parcelas excedido!");
                    Console.WriteLine("Inicie a operação novamente.");
                    return;
                }
                novoCredito.Pagar(precoCompra);

                    return;
                case 3:
                 //Debito
                 Debito debito = new Debito();
                debito.SalvarCartao();
                debito.Pagar(precoCompra);
                    return;
                case 0:
                Console.WriteLine("Muito Obrigado por acessar. Volte Sempre!");
                    return;
                default:
                Console.WriteLine("Opção Inválida");
                    break;
            }
            } while (escolha !=0);

            Console.WriteLine("Muito Obrigado por comprar conosco. Volte Sempre!");

            
            
            


        }
    }
}
