using System;

namespace AulaPOO_Abstracao.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;

        protected float valor ;

        public string Cancelar(){
            return "";
        }
         public abstract float Desconto(double valor);
    }
}