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
                if (is_perfect(i))
                    Console.Write(i + " ");

        }
        static bool is_perfect(int n)
        {
            int sum = 0;
        
            for (int i = 1; i < n; i++)
                if (n % i == 0)   //means that i is a divisor for n
                    sum += i;
            if (sum == n) return true;
            else return false;
        }
    }
}
