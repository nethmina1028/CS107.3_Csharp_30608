using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1Que3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a postive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            if (num < 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    result += i;
                }
            }

            Console.WriteLine("The sum of all the numbers are:" + result);
            Console.ReadLine();
        }
    }
}
