using System;
using POO_Encapsulamento.Classes;
namespace POO_Encapsulamento.Classes
{
    public class MasterCard: Cartao
    {
        private int parcelas;

        public void ExibirLimite(){
            System.Console.WriteLine(this.limite);
        }
        public string ComprarComDesconto(){
            return"";
        }
    }
}