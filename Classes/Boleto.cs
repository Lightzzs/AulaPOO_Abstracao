using System;
namespace AulaPOO_Abstracao.Classes
{
    public class Boleto : Pagamento
    {
       private string codigoDeBarras;
        float valorTotal;
        public bool boletos;
        public string CodigoDeBarras{
            get{return codigoDeBarras;} 
            set {codigoDeBarras = value;}
        }

        public void Registrar(string valor){
                this.codigoDeBarras = valor;
        }

        public override float Desconto(double valor)
        {  
            if(valor >= 1000){

            float desconto = 0.12f;
            float total = valorTotal - desconto;

            Console.WriteLine("Voce tera um desconto de: " + total);
            boletos = bool.Parse(Console.ReadLine());

            }else{
                Console.WriteLine("Sem desconto");
            }
                return 2;
        }

        internal void Desconto(bool boletos)
        {
            throw new NotImplementedException();
        }
    }
}