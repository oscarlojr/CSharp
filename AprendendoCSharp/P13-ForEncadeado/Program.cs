using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13 - For encadeado");


            //Desenhando asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {                   
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();

            }


            //Uma forma diferente para desenhar os asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
               
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write("*");
                
                Console.WriteLine();
            }   

            Console.ReadLine();
        }
    }
}
