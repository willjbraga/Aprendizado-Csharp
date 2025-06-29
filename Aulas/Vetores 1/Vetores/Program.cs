using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];

            for (int i = 0; i < N; i++)
            {
                altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double average = 0;

            for (int i = 0; i < N; i++)
            {
                average += altura[i];
            }

            average /= N;

            Console.WriteLine(average.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
