using System;

namespace AulaPOO_Abstracao.classes
{
    public abstract class Pagamento
    {
        private DateTime Data; 

        protected float valor;

        public string Cancelar(){
            return "";
        }

        public abstract string Desconto(int valor);

        
    }
}