namespace Exe19Dec
{
    public static class Looping2
    {
        /// <summary>
        /// Print Pascal's triangle up to N rows
        /// </summary>
        /// <param name="number">Input number upto which you want Pascal's triangle</param>
        public static void PascalTriangle(int number)
        {
            
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number upto which you want Pascal's triangle: ");
            int number = Convert.ToInt32(Console.ReadLine());
            PascalTriangle(number);
        }
    }
}