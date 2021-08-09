using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            //O Int é um tipo de variável de 32 bits
            int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            //O Long é uma variável de 64 bits
            long idade = 1300000000000000000;
            Console.WriteLine(idade);

            //O short é um tipo de variável de 32 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
