namespace Exe19Dec
{
    public class ValidDate
    {
        /// <summary>
        /// Check whether a date is valid
        /// </summary>
        /// <param name="d">Day</param>
        /// <param name="m">Month</param>
        /// <param name="y">Year</param>
        public void CheckDate(int d, int m, int y)
        {
            bool leap = y % 400 == 0 || (y % 4 == 0 && y % 100 != 0);
            int[] days = { 31, leap ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (m >= 1 && m <= 12 && d >= 1 && d <= days[m - 1])
                Console.WriteLine("Valid Date");
            else
                Console.WriteLine("Invalid Date");
        }

        public static void Main(string[] args)
        {
            ValidDate obj = new ValidDate();
            Console.WriteLine("Enter day, month, year:");
            int d = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            obj.CheckDate(d, m, y);
        }
    }
}
