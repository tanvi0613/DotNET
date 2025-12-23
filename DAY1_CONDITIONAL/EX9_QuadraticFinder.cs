namespace Exe19Dec
{
    public static class Quadrant
    {
        /// <summary>
        /// Take (x,y) coordinates and print which quadrant they lie in
        /// </summary>
        /// <param name="x">Input x Coordinate</param>
        /// <param name="y">Input y Coordinate</param>
        public static void QuadrantFinder(int x, int y)
        {
            if(x > 0 && y > 0)
            {
                Console.WriteLine("First Quadrant");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Second Quadrant");
            }
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("Third Quadrant");
            }
            else if(x > 0 && y < 0)
            {
                Console.WriteLine("Fourth Quadrant");
            }
            else
            {
                Console.WriteLine("On Axis");
            }
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());
            QuadrantFinder(x, y);
        }
    }
}
