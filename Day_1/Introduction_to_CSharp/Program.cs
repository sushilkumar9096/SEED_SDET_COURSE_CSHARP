using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name --");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is : " + name);
            Console.WriteLine("Enter you Last name --");
            string lname = Console.ReadLine();
            Console.WriteLine("Your name is :" + name + "  " + lname); //Concatination syntax
            Console.WriteLine("Your name is {0}  {1}", name, lname); //PlaceHolder Syntax 




            Console.WriteLine("Enter first number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Addtion of {0} + {1} = {2}", num1, num2, sum);
            Console.ReadLine();
        }
    }
}
