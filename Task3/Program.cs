using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int f0=1;
            int f1=1;
            int f2=0;
            int fib = 0;
            for(int i = 0; i<20; i++){
                if(i%2==0){
                f2 = f0+f1;
                f0=f2;
                }else{
                    f2 = f0+f1;
                    f1=f2;
                }
                if(f2>=1000 && f2<10000){
                    fib+=1;
                }
            }
            Console.WriteLine(fib);
        }
    }
}
