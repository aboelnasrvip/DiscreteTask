using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Enter n1 and n2: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
                if (is_prime(i))
                    Console.Write(i + " ");

        }
        static bool is_prime(int n)
        {
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0 || n<2) return false;
            else
            {
                for (int i = 3; i * i <= n; i += 2)
                    if (n % i == 0) return false;
            }
            return true;
        }
    }
}
