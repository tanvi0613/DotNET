namespace Exe19Dec
{
    public static class GradeDescription
    {
        /// <summary>
        /// Takes grade (E, V, G, A, F) and print (Excellent, Very Good, Good, Average, Fail) accordingly
        /// </summary>
        /// <param name="grade">Input grade to check</param>
        public static void GradeFinder(char grade)
        {
            char choice = char.ToUpper(grade);
            switch (grade)
            {
                case 'E':Console.WriteLine("Excellent");
                break;
                case 'V':Console.WriteLine("Very Good");
                break;
                case 'G':Console.WriteLine("Good");
                break;
                case 'A':Console.WriteLine("Average");
                break;
                case 'F':Console.WriteLine("Fail");
                break;
                default: Console.WriteLine("Invalid grade");
                break;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter grade: ");
            char grade = Console.ReadLine()!.Trim()[0];
            GradeFinder(grade);
        }
    }
}
