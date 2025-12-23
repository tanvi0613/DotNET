namespace Exe19Dec
{
    public class QuadraticEquation
    {
        /// <summary>
        /// Calculate roots of a quadratic equation
        /// </summary>
        /// <param name="a">Coefficient a</param>
        /// <param name="b">Coefficient b</param>
        /// <param name="c">Coefficient c</param>
        public void FindRoots(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double r1 = (-b + Math.Sqrt(d)) / (2 * a);
                double r2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Roots are real and different: " + r1 + ", " + r2);
            }
            else if (d == 0)
            {
                double r = -b / (2 * a);
                Console.WriteLine("Roots are real and same: " + r);
            }
            else
            {
                Console.WriteLine("Roots are imaginary");
            }
        }

        public static void Main(string[] args)
        {
            QuadraticEquation obj = new QuadraticEquation();
            Console.WriteLine("Enter a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            obj.FindRoots(a, b, c);
        }
    }
}
