using System;

namespace IndVariant7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 вещественных числа");
            Console.WriteLine("x=?");
            double x = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("y=?");
            double y = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("z=?");
            double z = Convert.ToSingle(Console.ReadLine());
            
            if(x>y && y>z){
                double a = x-z;
                Console.WriteLine(a);
            }else if(x>z && z>y){
                double a = x-y;
                Console.WriteLine(a);
            }else if(y>x && x>z){
                double a = y-z;
                Console.WriteLine(a);
            }else if(y>z && z>x){
                double a = y-x;
                Console.WriteLine(a);
            }else if(z>x && x>y){
                double a = z-y;
                Console.WriteLine(a);
            }else if(z>y && y>x){
                double a = z-x;
                Console.WriteLine(a);
            }else if(x==y || y==z || x==z){
                if(x>z){
                    Console.WriteLine("Числа x и y равны");
                    double a = x-z;
                    Console.WriteLine(a);
                }else if(y>x){
                    Console.WriteLine("Числа y и z равны");
                    double a = y-x;
                    Console.WriteLine(a); 
                }else if(x>y){
                    Console.WriteLine("Числа x и z равны");
                    double a = x-y;
                    Console.WriteLine(a);
                }
            }
        }   
    }
}