using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace property1
{
    class sample
    {
        int b;
        public int a
        {
            get { return 20; }
            set { b = value; }

        }
        public void setValue()
        {
            this.a = 50;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            sample obj = new sample();
            //obj.setValue();
            //obj.a = 30;
            Console.WriteLine("Test : " + obj.a);
       
        }
    }
}
