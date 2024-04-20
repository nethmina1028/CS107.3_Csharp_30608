using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1Que2
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd. ");
                }
                Console.ReadLine();
            }
        }
    }
}
