namespace AulaPOO_Abstracao.classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;


        public void Pagar(float valor){
            
        }

        public override string Desconto(int valor)
        {
            return "";
        }
    }
}