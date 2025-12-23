namespace Exe19Dec
{
    public class LeapYearChecker
    {
        /// <summary>
        /// Check if a year is leap year
        /// </summary>
        /// <param name="year">Input year to check</param>
        public static void CheckLeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not a Leap Year");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            CheckLeapYear(year);
        }
    }
}
