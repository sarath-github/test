using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class MyClass1
    {
        public string name;
        public MyClass1()
        {
            name = string.Empty;
        }
        public MyClass1(string name)
        {
            this.name = name;
        }
        public int getLen()
        {
            return name.Length;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Name is: " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int choice=0;
            MyClass1 obj = new MyClass1("abd");
            while(choice!=4){
                Console.WriteLine("1.Display\n2.SetName\n3.GetLength\n4.Exit\nEnter your choice:");
                choice = int.TryParse(Console.ReadLine());
                switch (choice)
                {
                    case 1: obj.display();
                        break;
                    case 2: Console.WriteLine("\nEnter the name:");
                        obj.setName(Console.ReadLine());
                        break;
                    case 3: Console.WriteLine("\nName Length is: " + obj.getLen());
                        break;
                    case 4: break;
                }
            }

        }
    }
}
