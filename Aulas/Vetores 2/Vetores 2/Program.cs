using System;
using System.Globalization;

namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Produto[] p = new Produto[N];

            for (int i = 0; i < N; i++)
            {
                string nome = Console.ReadLine();
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                p[i] = new Produto { Nome = nome, Valor = valor };
            }

            double average = 0;

            for (int i = 0; i < N; i++)
            {
                average += p[i].Valor;
            }

            average /= N;

            Console.WriteLine("AVERAGE PRICE : " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
