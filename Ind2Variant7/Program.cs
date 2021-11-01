using System;

namespace Ind2Variant7
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10;i<100;i++){
                
                double a = (double)i / 10;
                
                double a1 = Math.Floor(a);
                
                int b = Convert.ToInt32((a-a1)*10);
                
                double c = a1+b;
                
                 if(c%5==0){
                     Console.WriteLine(i);
                 }
            }
        }
    }
}
