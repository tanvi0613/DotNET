namespace Exe19Dec
{
    public class HeightCategory
    {
        /// <summary>
        /// Check height and classify into dwarf, average, tall or abnormal
        /// </summary>
        /// <param name="height">Input height to check</param>
        public void checkHeight(int height)
        {
             if(height < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if(height >= 150 && height<165)
            {
                Console.WriteLine("Average");
            }
            else if(height >= 165 && height <= 190)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal");
            }
        }

        /// <summary>
        /// Main Function (entry point)
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            HeightCategory obj = new HeightCategory();

            //Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).
            Console.WriteLine("Enter height in cm: ");
            int height = Convert.ToInt32(Console.ReadLine());
            obj.checkHeight(height);
        }
    }
}
