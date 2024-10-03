using System;

namespace uppgift2_4
{
    class program
    {
        static void Main(string[] args) 
            {
            Console.WriteLine("vad är lönet för person 1");
            int P1= int.Parse(Console.ReadLine());
            Console.WriteLine("vad är löner för person 2");
            int P2= int.Parse(Console.ReadLine());
            Console.WriteLine("vad är lönet för person 3");
            int P3= int.Parse(Console.ReadLine());        
            int sum = (P1 + P2 + P3) / 3;
            Console .WriteLine(sum);






            }

    }



}