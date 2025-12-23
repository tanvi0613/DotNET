namespace Exe19Dec
{
    public class AdmissionEligibility
    {
        /// <summary>
        /// Check is student is eligible for admission
        /// </summary>
        /// <param name="math">Enter math marks</param>
        /// <param name="phy">Enter physics marks</param>
        /// <param name="chem">Enter chemistry marks</param>
        /// <returns>Eligibility true or false</returns>
        public void IsEligible(int mathMarks,int phyMarks,int chemMarks)
        {
            int total = mathMarks + phyMarks + chemMarks;
            if(mathMarks >= 65 && phyMarks >= 55 && chemMarks >= 50)
            {
                if(total >= 180 || (mathMarks + phyMarks) >= 140)
                {
                    Console.WriteLine("Eligible for admission");
                }
                else
                {
                    Console.WriteLine("Not Eligible for admission");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible for admission");
            }
        }
        public static void Main(string[] args)
        {
            AdmissionEligibility obj = new AdmissionEligibility();
            Console.WriteLine("Enter math marks: ");
            int mathMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter physics marks: ");
            int phyMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter chemistry marks: ");
            int chemMarks = Convert.ToInt32(Console.ReadLine());
            obj.IsEligible(mathMarks,phyMarks,chemMarks);
        }

    }
}