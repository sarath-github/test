using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace methods1
{
    class sample
    {
        int a;
        String name;
        long reg_no, ph_no;
        public sample()
        {
            a = 0;
            reg_no = ph_no = 0;
            name = String.Empty;
        }
        public void getDetails()
        {
            Console.WriteLine("\nEnter the name: ");
            name = Console.ReadLine();
            Console.WriteLine("\nEnter the age: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the reg. no.: ");
            reg_no = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the Phone number: ");
            ph_no = int.Parse(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("\nName: {0}\nAge: {1}\nRegister Number: {2}\nPhone Number: {3}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            sample obj = new sample();
            do
            {
                Console.WriteLine("1.Enter details(change): \n2.Display Details: \n3.Exit \nEnter your choice: ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        obj.getDetails();
                        break;
                    case 2:
                        obj.display();
                        break;
                    default:
                        Console.WriteLine("Invalid input...");
                        break;
                }
            } while (ch != 3);
        }
    }
}
