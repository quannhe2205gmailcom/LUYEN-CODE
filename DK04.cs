using System;
using system.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;
	0references
namespace VL01{
 class Program
 {	0references
     static void Main(string[] args){
         var s = Console.Readline();
         var s1 = 5.Split(' ');
         int a = Convert.ToInt32(s1[0]);
         int b = Convert.ToInt32(s1[1]);
         for (int i = a; i<= b; i++){
             Console.Write("{0} ", i);
         }
         Console.Realine();
     }
 }
}
