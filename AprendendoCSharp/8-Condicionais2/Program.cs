using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João Pode entrar.");
            }
            else
            {
                
                Console.WriteLine("João Não pode entrar.");
                
            }

            Console.ReadLine();


        }
    }
}
