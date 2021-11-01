using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Введите N от 1 до 100");
             double N = Convert.ToSingle(Console.ReadLine());
                if(N>=1 && N<=100)
                {
                     if(N>=1 && N<=100)
                    {
                       double a = Convert.ToDouble(N/10);
                       Console.WriteLine(a);
                       double a1 = Convert.ToInt32(((a-Math.Truncate(a))*10));
                       Console.WriteLine(a1);     
                       if(a1==0 || a1==5 || a1==6 || a1==7 || a1==8 || a1==9)
                       {
                         Console.WriteLine("{0} лет",N);  
                       }
                       else if(a1==1)
                       {
                           Console.WriteLine("{0} год",N);
                       }
                       else
                       {
                           Console.WriteLine("{0} года",N);
                       }
                    }    
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
    }
}
