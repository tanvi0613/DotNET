using System;
namespace Exe19Dec
{
    public class Looping
    {
        /// <summary>
        /// Display the first N terms of the Fibonacci sequence
        /// </summary>
        /// <param name="n">Enter number till which you want the series</param>
        public void FibonacciSeries(int number)
        {
            int sum=0;
            int prev1 = 0;
            int prev2 = 1;
            Console.Write(prev1 + " " + prev2 + " ");
            for(int i = 0; i < number; i++)
            {
                sum = prev1 + prev2;
                prev1 = prev2;
                prev2 = sum;
                Console.Write(sum + " ");
            }
        }

        /// <summary>
        /// Check if a number is prime using a for loop and break
        /// </summary>
        /// <param name="number">Input to check for prime</param>
        public void IsPrime(int number)
        {
            int noOfDivisors = 0;
            for(int i=1; i<number/2; i++)
            {
                if(number % i == 0)
                {
                    noOfDivisors++;
                }
            }

            if(noOfDivisors == 1)
            {
                Console.WriteLine("The number is Prime");
            }
            else
            {
                Console.WriteLine("The number is not Prime");
            }
        }

        /// <summary>
        /// Check if a number equals the sum of its digits raised to the power of number of digits
        /// </summary>
        /// <param name="number">Input to check for armstrong</param>
        public void IsArmstrongNumber(int number)
        {
            int numberCopy = number;
            int numOfDigits = 0;
            int sumOfDigits=0;

            //Finding the number of digits in the provided number
            while(numberCopy > 0)
            {
                int digit = numberCopy % 10;
                numOfDigits++;
                numberCopy/=10;
            }

            numberCopy = number;

            //Summing the digits of number to the power of the num of digits
            while(numberCopy > 0)
            {
                int digit = numberCopy % 10;
                sumOfDigits += (int)Math.Pow(digit, numOfDigits);
                numberCopy /= 10;
            }

            if(sumOfDigits == number)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong");
            }
        }

        /// <summary>
        /// Reverse an integer and check if it is a palindrome
        /// </summary>
        /// <param name="number">Input a number to check for palindrome</param>
        public void IsPalindromeNumber(int number)
        {
            int numberCopy = number;
            int reversedNumber = 0;
            while(numberCopy > 0)
            {
                int digit = numberCopy % 10;
                reversedNumber = reversedNumber * 10 + digit;
                numberCopy/=10;
            }

            if(reversedNumber == number)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }

        /// <summary>
        /// Find the Greatest Common Divisor of two numbers
        /// </summary>
        /// <param name="num1">Input first number</param>
        /// <param name="num2">Input second number</param>
        public int Gcd(int num1, int num2)
        {
           while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        /// <summary>
        /// Find the Least Common Multiple of two numbers
        /// </summary>
        /// <param name="num1">Input first number</param>
        /// <param name="num2">Input second number</param>
        public int LCM(int num1, int num2)
        {
            int gcd = Gcd(num1, num2);
            return (num1 / gcd) * num2;
        }

        /// <summary>
        /// Main Method
        /// </summary>
        public static void Main(string[] args)
        {
            Looping loop = new Looping();

            ///CHECKING FIBONACCI SERIES
            // Console.WriteLine("Enter a number till which you want the fibonacci series: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // loop.FibonacciSeries(number);

            //CHECKING FOR PRIME
            // Console.WriteLine("Enter a number to check for prime: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // loop.IsPrime(number);

            //ARMSTRONG NUMBER
            // Console.WriteLine("Enter a number to check for armstrong: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // loop.IsArmstrongNumber(number);

            //PALINDROME NUMBER
            // Console.WriteLine("Enter a number to check for palindrome: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // loop.IsPalindromeNumber(number);

            //FINDING GCD AND LCM OF TWO NUMBERS
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int gcdResult = loop.Gcd(num1, num2);
            int lcmResult = loop.LCM(num1, num2);
            Console.WriteLine("The GCD of " + num1 + " and " + num2 + " is: " + gcdResult);
            Console.WriteLine("The LCM of " + num1 + " and " + num2 + " is: " + lcmResult);
        }
    }
}