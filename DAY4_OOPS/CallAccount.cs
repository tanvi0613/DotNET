namespace OopsSessions
{
    public class CallAccount
    {
        public static void Main(string[] args)
        {
            Account account = new Account(){AccountId = 46289, Name = "ABC"};
            string result = account.GetAccountDetails();
            System.Console.WriteLine(result);

            SalesAccount salesAccount = new SalesAccount(){AccountId = 16732, Name = "XYZ", SalesInfo = "You've sold something!"};
            string result1 = salesAccount.GetSalesAccountDetails();
            System.Console.WriteLine(result1 + '\n');

            PurchaseAccount purchaseAccount = new PurchaseAccount(){AccountId = 89232, Name = "PQR", PurchaseInfo = "Your purchase amount was huge!"};
            string result2 = purchaseAccount.GetPurchaseAccountDetails();
            System.Console.WriteLine(result2);
        }
    }
}