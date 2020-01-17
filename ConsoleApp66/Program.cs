using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] tab1 = new int[1000];
            int i = 0;
            do
            {
                Console.WriteLine("Tell me natural number");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            while (n!=0)
            {
                tab1[i++] = n % 8;
                n /= 8;
            }
            Console.WriteLine("The same number in octal: ");
            for (int j = i - 1; j >= 0; j--) Console.Write(tab1[j]);
            Console.ReadKey();
        }
    }
}
