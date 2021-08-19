using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 9 - Escopo");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            string mensagemAdicional;
            bool acompanhado = quantidadePessoas >= 2;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado!";
            }
            
            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {

                Console.WriteLine("João Não pode entrar.");

            }

            Console.ReadLine();


        }
    }
}
