namespace AulaPOO_Abstracao.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira ;

        public string numero;

        public string titular;

        public string cvv;


        // metodo

        public string SalvarCartao(){
            return "";
        }
        public override float Desconto(double valor){
            return 2;
        }

    }
}