using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class2
{
    public struct sample
    {
        public int a;
        public int b;
        
         public sample(int c,int d)
         {
             a = c;
             b = d;
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj1 = new sample();
            sample obj2 = new sample(10, 20);
            Console.WriteLine("test obj1: " + obj1.a+" " + obj1.b);
            Console.WriteLine("Test obj2: " + obj2.a + " " + obj2.b);
        }
    }
}
