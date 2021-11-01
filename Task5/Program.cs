using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            Console.WriteLine("Введите натуральное число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
             for (int x = 1; x < N; x++)
            {
                for (int y = 1; y < N; y++)
                {
                    for (int z = 1; z < N; z++)
                    {
                        double result = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);
                        if (result == N)
                        {
                              Console.WriteLine("Ответ: N = {0}^3 + {1}^3 + {2}^3", x, y, z);
                        }


                    }
                }

            }
        }

                                                
            
        
    }
}

}
