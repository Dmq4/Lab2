using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a,b,c");
            Console.WriteLine("a=?");
            double a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("b=?");
            double b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("c=?");
            double c = Convert.ToSingle(Console.ReadLine());

            double Dis = Math.Sqrt(Math.Pow(b,2)-4*a*c);

            if(Dis>0){
                double x1 = (-b+Dis)/2*a;
                double x2 = (-b-Dis)/2*a;
                Console.WriteLine("x1 = {0}, x2 = {1}",x1,x2);
            }else if (Dis==0){
                double x = -b/2*a;
                Console.WriteLine("x = {0}",x);
            }else{
                double Dis1 = Math.Sqrt(-(Math.Pow(b,2)-4*a*c))/2*a;
                double y = -b/2*a;
                Console.WriteLine("x1 = {0}+i*{1}",y,Dis1);
                Console.WriteLine("x2 = {0}-i*{1}",y,Dis1);  
            }

        }
    }
}
