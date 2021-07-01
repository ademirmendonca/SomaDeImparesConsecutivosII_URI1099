using System;

namespace SomaDeImparesConsecutivosII_URI1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);                

                if (x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int total = 0;
                for (int j = x + 1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        total = total + j;
                    }
                }

                Console.WriteLine(total);
            }
        }
    }
}
