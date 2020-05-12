using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=8;
            for(int i = 0; i < n; i++)
            {
                for(int j = n - i - 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
