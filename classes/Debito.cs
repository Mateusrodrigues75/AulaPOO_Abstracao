namespace AulaPOO_Abstracao.classes
{
    public class Debito : Cartao
    {
        private float saldo = 600;

        public void Pagar(float valor){
            
        }

        public override string Desconto(int valor)
        {
            return "";
        }
    }
}