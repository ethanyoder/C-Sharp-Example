using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter year born:");
            int yearBorn = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age");
            int yearsAlive = System.Convert.ToInt32(Console.ReadLine());


            for (int i = yearBorn; i <= yearBorn + yearsAlive; i++)
            {
                Console.WriteLine(name + ": " + i);
            }

            Console.ReadKey();
            
        }
    }
}
