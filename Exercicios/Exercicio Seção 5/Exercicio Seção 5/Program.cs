using System;
using System.Globalization;

namespace Exercicio_Seção_5 {
    internal class Program {
        static void Main(string[] args) {

            int numero;
            string titular;
            char dep_inicial;
            double saldo;

            ContaBancaria conta;


            Console.Write("Entre o número da conta: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Entre o titular da conta: ");
            titular = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            dep_inicial = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (dep_inicial == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                conta = new ContaBancaria(numero, titular, saldo);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(conta);

        }
    }
}