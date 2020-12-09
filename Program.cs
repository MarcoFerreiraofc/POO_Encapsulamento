using System;
using POO_Encapsulamento.Classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
           MasterCard m = new MasterCard();

           m.NomeTitular ="Marco A. ";

           m.Numero = "00000000"; 

            m.Bandeira = "MasterCard";

           Console.WriteLine($"O titular {m.NomeTitular} - Token {m.Token}"); 
        }
    
    }
}