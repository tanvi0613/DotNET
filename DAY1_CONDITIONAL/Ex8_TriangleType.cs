namespace Exe19Dec
{
    public static class TriangleType
    {
        /// <summary>
        /// Check if a triangle is Equilateral, Isosceles, or Scalene based on side lengths
        /// </summary>
        /// <param name="side1">Input for side 1</param>
        /// <param name="side2">Input for side 2</param>
        /// <param name="side3">Input for side 3</param>
        public static void TriangleFinder(int side1, int side2, int side3)
        {
            if(side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if(side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("Scalene Triangle");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first side of triangle: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second side of triangle: ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third side of triangle: ");
            int side3 = Convert.ToInt32(Console.ReadLine());
            TriangleFinder(side1, side2, side3);
        }
    }
}
