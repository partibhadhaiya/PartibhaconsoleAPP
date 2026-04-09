//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace PartibhaconsoleAPP
//{
//    internal class Function
//    {

//        static void Main()
//        {
//            int a = 7, b = 8;
//            Console.WriteLine($"Values before swapping: a={a} and b={b}");
//            Swap(a, b);
//            Console.WriteLine($"Values after swapping: a={a} and b={b}");

//            Swapref(ref a, ref b); //c# don't have pointers and call by reference is achieved by using ref keyword
//            Console.WriteLine($"value after swapping call by reference: a={a} and b={b}");
//            int hindi = 20, english = 30, math = 49;
//            int sum, average; 
//            Result(hindi,english,math,out sum,out average);//out type is new in c#  . it is combination of call by refernce and call by value
//            Console.WriteLine($"sum={sum} and average={average}");

//        }



//        static void Swap(int a, int b)//call by value
//        {
//            int temp = a;
//            a = b;

//            b = temp;
//        }



//        static void Swapref(ref int a, ref int b)//call by reference
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//        }

//        static void Result(int hindi, int english, int math, out int sum, out int average)
//        {
//            sum = hindi + english + math;
//            average = sum / 3;
//        }
//    }
//}