namespace Exe19Dec
{
    public class ProfitLoss
    {
        /// <summary>
        /// Calculate profit or loss percentage
        /// </summary>
        /// <param name="cp">Cost price</param>
        /// <param name="sp">Selling price</param>
        public void Calculate(double cp, double sp)
        {
            if (sp > cp)
                Console.WriteLine("Profit % = " + ((sp - cp) / cp) * 100);
            else if (cp > sp)
                Console.WriteLine("Loss % = " + ((cp - sp) / cp) * 100);
            else
                Console.WriteLine("No Profit No Loss");
        }

        public static void Main(string[] args)
        {
            ProfitLoss obj = new ProfitLoss();
            Console.WriteLine("Enter CP and SP:");
            double cp = Convert.ToDouble(Console.ReadLine());
            double sp = Convert.ToDouble(Console.ReadLine());
            obj.Calculate(cp, sp);
        }
    }
}
