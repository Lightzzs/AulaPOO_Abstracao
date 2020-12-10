using System;
using AulaPOO_Abstracao.Classes;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boletoPago = new Boleto();
            Credito credito = new Credito();
            Debito debito = new Debito();
            int escolha;

            Console.WriteLine("Qual o valor da fatura?");
            float valor = float.Parse(Console.ReadLine());

             Console.WriteLine("Como você deseja pagar?");
             Console.WriteLine("Selecione uma opção abaixo");
             Console.WriteLine("1 Boleto");
             Console.WriteLine("2 Cartão");
             Console.WriteLine("0 Sair");
             escolha = int.Parse(Console.ReadLine());


            switch(escolha){

            case 1:
            Console.WriteLine("Boleto");
            string  resposta  =  Console.ReadLine();
            
            if(resposta.ToLower() == "s"){
                boletoPago.boletos = true;
                boletoPago.Desconto(boletoPago.boletos);
            }else{
                boletoPago.boletos = false;
                boletoPago.Desconto(boletoPago.boletos);
            }
            break;

            case 2:
            Console.WriteLine("credito ou debito ? C/D");
            String resposta = Console.ReadLine();

            if(resposta == C){
                
            }
            
                default:
                break;
            }
        }
    }
}