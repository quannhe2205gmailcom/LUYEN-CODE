using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine(); //s="1 2 3
            var s1 = s.Split(' '); //s1[0]="1" s1[1]="2" s1[2]="3"
            int a = Convert.ToInt32(s1[0]);
            int b = Convert.ToInt32(s1[1]);
            int c = Convert.ToInt32(s1[2]);
            int d = a + b + c;
            Console.WriteLine(d);
        }
    }
}
