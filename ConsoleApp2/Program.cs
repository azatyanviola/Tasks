using System;

namespace ConsoleApp2
{
    internal class Program
    {


        // Fibonacci series

        static int Fib(int num)
        {
            if (num == 1)
            {
                return 0;
            }
            else if (num == 2)
            {
                return 1;
            }
            else
            {
                return Fib(num - 1) + Fib(num - 2);
            }
        }
        //Prime number
        static bool Prime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        //Reverse number
        static int Reverse(int n)
        {
            int reverse = 0, rem;
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            return reverse;
        }

        //Palindrome number

        static int Reversed(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            return rev;
        }

        // Function that returns true
        // if num is palindrome
        static bool Palindrome(int num)
        {
            if (num == Reversed(num))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void PrintPalindromes(int d)
        {
            if (d <= 0)
            {
                return;
            }
            for (int i = 1; i <= d; i++)
            {
                if (Palindrome(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        // Factorial
        static int Fact(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Fact(n - 1);
            }
        }


        static bool Armstrong(int x)
        {
            int sum = 0;
            int tempX = x;
            int temp = 0;
            int length = x.ToString().Length;

            while (x != 0)
            {
                temp = x % 10;
                x = x / 10;
                sum += (int)Math.Pow(temp, length);
            }

            if (sum == tempX)
                return true;
            else
                return false;
        }





        static void Main(string[] args)
        {

            // Console.WriteLine($"The  term of the Fibonacci sequence is {Fib(5)}.");

            //Console.WriteLine(Prime(11));

            // Console.WriteLine($"The  Factorial   is {Fact(5)}.");

            //Console.WriteLine("The reversed number is " + " " +  Reverse(65));

            //PrintPalindromes(100);


            Console.WriteLine(Armstrong(1634));




            //*******Swap two numbers

            //int a = 5, b = 11;
            //Console.WriteLine("Before swap a= " + a + " b= " + b);
            //a = a * b;
            //b = a / b;
            //a = a / b;
            //Console.Write("After swap a= " + a + " b= " + b);


        }
    }
}
