using System;

namespace AulaPOO_Abstracao.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;

        public new string SalvarCartao(){
            Console.Write("Digite a Bandeira do Cartão: ");
            bandeira = Console.ReadLine();
            
            Console.Write("Digite o Número do Cartão: ");
            numero = Console.ReadLine();
            
            Console.Write("Digite o nome do titular do Cartão: ");
            titular = Console.ReadLine();
            
            Console.Write("Digite o número do cvv: ");
            cvv = Console.ReadLine();
            return "Cartão Salvo";
        }
        public void Pagar(float valor){
            if(valor <= saldo){
                Console.WriteLine("Compra Aprovada!");
            }else{
                Console.WriteLine("Saldo Insuficiente - Compra Não Autorizada");
            }    
        }

    
    }
}