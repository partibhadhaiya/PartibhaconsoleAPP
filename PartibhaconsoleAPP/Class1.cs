using System;
using System.Collections.Generic;
using System.Text;

namespace PartibhaconsoleAPP
{
    internal class Class1
    {
       static void Main()
        {
            int n1, n2, sum;
            Console.WriteLine("Enter first no.");
            n1= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter second no.");
            n2= Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine($"the sum of {n1} and {n2} is {sum}");
        }
    }
}
