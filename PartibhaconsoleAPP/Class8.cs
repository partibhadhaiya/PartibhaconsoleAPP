using System;
using System.Collections.Generic;
using System.Text;

namespace PartibhaconsoleAPP
{
    internal class Fucntion
    {
        static void Main()
            //only a static function can call another static function directly without creating an object of the class
        {
             msg();
            table(5);
            factorial(5);
            Console.WriteLine("Factorial of 5 is " + factorial(5));
            Console.WriteLine("Value of pi is " + getpi());
            
             
        }

        static void msg()//function without return type and without parameter
        {
            Console.WriteLine("Hello World");
        }

        static void table(int x)// function without return type but accepting a value
          
        {
            int i;
            for( i = 1; i < 11; i++)
            {
                Console.WriteLine($"{x} x{i}={x * i}");
            }
        }

        static int factorial(int x)
        { //function with return type and accepting a value

            if (x == 0){
                return 1;
            }
            else
            {
                return factorial(x - 1) * x;
            }
        }
        static double getpi() //This function doesnot accept any value but return a value
        {
            return 3.14;
        }
    }
}
