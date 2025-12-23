namespace Exe19Dec
{
    public class ATM
    {
        /// <summary>
        /// Check ATM withdrawal conditions
        /// </summary>
        /// <param name="card">Card inserted</param>
        /// <param name="pin">Pin valid</param>
        /// <param name="balance">Balance sufficient</param>
        public void Withdraw(bool card, bool pin, bool balance)
        {
            if (card)
                if (pin)
                    if (balance)
                        Console.WriteLine("Withdrawal successful");
                    else
                        Console.WriteLine("Insufficient balance");
                else
                    Console.WriteLine("Invalid PIN");
            else
                Console.WriteLine("Insert card");
        }

        public static void Main(string[] args)
        {
            ATM obj = new ATM();
            obj.Withdraw(true, true, true);
        }
    }
}
