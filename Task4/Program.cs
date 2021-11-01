using System;

namespace Task4
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения x и q");
            
            Console.WriteLine("x=?");
            
            double x = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("q=?");
            
            double q = Convert.ToSingle(Console.ReadLine());
            
            double x1 = (Math.PI/180)*x;

            double cos = 1;

            double result = 0;

            double kolich = 0;

            
            for(int n = 1; n<1000; n++){
                result = (Math.Pow(-1,n)*Math.Pow(x1,2*n)/Factorial(2*n));
                if(Math.Abs(result)<q)
                {
                    break;
                }
                cos+=result; 
                kolich+=1;
            } 
            
             Console.WriteLine("Значение cos(x): {0}, количество слагаемых при заданном q:{1}",cos,kolich); 
        }

        static double Factorial(double n){
            double fac = 1;
            for(int i = 1; i<n; i++){
                fac*=i;
            }
            return fac;
        }

   }

}
