using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1Que5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            if (num < 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    result = num * i;
                    Console.WriteLine(num + " x " + i + "= " + result);
                }
            }

            Console.ReadLine();
        }
    }
}
