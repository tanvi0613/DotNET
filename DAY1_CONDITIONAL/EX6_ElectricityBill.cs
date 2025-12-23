namespace Exe19Dec
{
    public static class ElectricityBill
    {
        /// <summary>
        /// Calculate bill: First 199 units @ 1.20; 200-400 @ 1.50; 400-600 @ 1.80; above 600 @ 2.00. Add 15% surcharge if bill > 400
        /// </summary>
        /// <param name="units">Input units consumed</param>
        public static void CalculateElectricityBill(double units)
        {
            double bill = 0;

            if (units <= 199)
            {
                bill = units * 1.20;
            }
            else if (units <= 399)
            {
                bill = (199 * 1.20) + (units - 199) * 1.50;
            }
            else if (units <= 599)
            {
                bill = (199 * 1.20) + (200 * 1.50) + (units - 399) * 1.80;
            }
            else
            {
                bill = (199 * 1.20) + (200 * 1.50) + (200 * 1.80) + (units - 599) * 2.00;
            }

            if (bill > 400)
            {
                bill += bill * 0.15;
            }

            Console.WriteLine("The total bill amount is: " + bill);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter electricity units consumed: ");
            double units = Convert.ToDouble(Console.ReadLine());
            CalculateElectricityBill(units);
        }
    }
}
