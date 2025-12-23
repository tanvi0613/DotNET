namespace Exe19Dec
{
    public class LargestOfThree
    {
        /// <summary>
        /// Take three integers and find the maximum number
        /// </summary>
        /// <param name="num1">Input first number</param>
        /// <param name="num2">Input second number</param>
        /// <param name="num3">Input third number</param>
        public void LargestNum(int num1, int num2, int num3)
        {
            int largest;

            if (num1 >= num2 && num1 >= num3)
                largest = num1;
            else if (num2 >= num1 && num2 >= num3)
                largest = num2;
            else
                largest = num3;

            Console.WriteLine("Largest number is: " + largest);
        }

        public static void Main(string[] args)
        {
            LargestOfThree obj = new LargestOfThree();

            Console.WriteLine("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            obj.LargestNum(num1, num2, num3);
        }
    }
}
