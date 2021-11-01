using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во слагаемых");
            int n = Convert.ToInt32(Console.ReadLine());
            double S = 1;
            double PI = 0;
            
            for(int i = 1; i<=n; i++){
               if(i%2!=0){
                   PI  += (1/S);
               }else{
                    PI -= (1/S);
               }
                S+=2;
            }
            Console.WriteLine("Число ПИ при данных слогаемых равно:{0}",PI*4);


        }
    }
}
