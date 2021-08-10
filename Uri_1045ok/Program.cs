using System;
using System.Globalization;

namespace Uri_1045ok
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double l1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double l2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double l3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double A, B, C;
            if (l1 > l2 && l1 > l3)
            {
                A = l1;
                if (l2 > l3)
                {
                    B = l2;
                    C = l3;
                }
                else
                {
                    B = l3;
                    C = l2;
                }
            }
            else if (l2 > l3)
            {
                A = l2;
                if (l1 > l3)
                {
                    B = l1;
                    C = l3;
                }
                else
                {
                    B = l3;
                    C = l1;
                }
            }
            else
            {
                A = l3;
                if (l1 > l2)
                {
                    B = l1;
                    C = l2;
                }
                else
                {
                    B = l2;
                    C = l1;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (A * A == B * B + C * C)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (A * A > B * B + C * C)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
