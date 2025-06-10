using System;
using System.Globalization;

namespace Exercicio_Seção_5 {
    internal class Program {
        static void Main(string[] args) {

            int conta;
            string titular;
            char dep_inicial;
            double saldo;

            Console.Write("Entre o número da conta: ");
            conta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Entre o titular da conta: ");
            titular = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            dep_inicial = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Conta c = new Conta(conta, titular);

            if (dep_inicial == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                c.Deposito(saldo);
            }

            Console.WriteLine(c);

            Console.Write("Entre um valor para depósito: ");
            c.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(c);

            Console.Write("Entre um valor para saque: ");
            c.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(c);



        }
    }
}