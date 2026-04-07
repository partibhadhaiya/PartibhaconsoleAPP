using System;
using System.Collections.Generic;
using System.Text;

namespace PartibhaconsoleAPP
{
    internal class Class3
    {
        static void Main()
        {
            int n1, n2, product;
            Console.WriteLine("Enter first no.");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second no.");
            n2 = Convert.ToInt32(Console.ReadLine());
            product = n1 * n2;
            Console.WriteLine($"THE PRODUCT IS {product}");
        }
    }
}