using System;
namespace Ngay2{
    class Program {
        static void Main(string[] args)
    	{
            string s = Console.ReadLine();
            long n = Convert.Toint32(s);
            if (chinhphuong(n))
            	Console.WhiteLine("YES");
            else
            	Console. WhiteLine("NO");
        }
        static bool chinhphuong(long m){
            if (m<0) return false;
            else{
                long x = (long)Math.Round(Math.Sqrt(m));
                if (x * x == m) return true;
                else return false;
            }
        }
    }
}
