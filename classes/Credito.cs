using System;

namespace AulaPOO_Abstracao.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        


        public void Pagar(float valor){
            if(valor <= limite){
                Console.WriteLine("Compra Aprovada!");
            }else{
                Console.WriteLine("Limite Excedido - Compra não autorizada!");
            }    
        }
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
        public bool Parcelar(int numeroParcelas){
            if(numeroParcelas <=6){
                valor = valor*0.95f;
                return true;
            }if(numeroParcelas >6 && numeroParcelas<=12){
                valor = valor*0.92f;
                return true;
            }
            return false;

        }

       
    }
}