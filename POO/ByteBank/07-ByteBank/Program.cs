using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine(ContaCorrente.TottalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86712520);
            Console.WriteLine(ContaCorrente.TottalDeContasCriadas);


            Console.ReadLine();
        }
    }
}
