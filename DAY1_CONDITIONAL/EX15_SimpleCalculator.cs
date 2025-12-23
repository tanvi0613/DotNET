namespace Exe19Dec
{
    public class Calculator
    {
        /// <summary>
        /// Perform arithmetic operation
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="op">Operator</param>
        public void Calculate(double a, double b, char op)
        {
            switch (op)
            {
                case '+': Console.WriteLine(a + b); break;
                case '-': Console.WriteLine(a - b); break;
                case '*': Console.WriteLine(a * b); break;
                case '/': Console.WriteLine(b != 0 ? a / b : "Divide by zero"); break;
                default: Console.WriteLine("Invalid operator"); break;
            }
        }

        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            Console.WriteLine("Enter a, b and operator:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            char op = Console.ReadLine()[0];
            obj.Calculate(a, b, op);
        }
    }
}
