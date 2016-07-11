using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class MyClass1
    {
        public int Number {get;set;}
        public int Multiply(int num)
        {
            return num * Number;
        }
        public MyClass1()
        {
            Number = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myClass = new MyClass1();
            myClass.Number = 27;
            int result = myClass.Multiply(4);
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
            Console.WriteLine("Result: " + result);
        }
    }
}
