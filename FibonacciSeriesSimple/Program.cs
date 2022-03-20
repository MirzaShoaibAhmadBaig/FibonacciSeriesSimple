using System;

namespace FibonacciSeriesSimple
{
    class Program
    {
       static int Firstnum = 0, SecondNum = 1, Final;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Your number");
            int UserNum = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < UserNum; i++)
            {
                Final = Firstnum + SecondNum;
                Console.WriteLine(Final);

                Firstnum = SecondNum;
                SecondNum = Final;


            } 
            




        }
    }
}
