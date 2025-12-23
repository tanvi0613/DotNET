namespace OopsSessions
{
    /// <summary>
    /// If put 'sealed' no one can inherit this class
    /// </summary>
    public sealed class CreditCardAccount{}
    public class Account
    {
        public int AccountId{get; set;}
        public string? Name{get; set;}
        public string GetAccountDetails()
        {
            return $"I am base account. My Id is {AccountId} {Environment.NewLine}";
        }
    }

    public class SalesAccount : Account
    {
        public string? SalesInfo{get; set;}
        public string GetSalesAccountDetails()
        {
            string info = string.Empty;
            info += base.GetAccountDetails();
            info += "I am from Sales Derived Class. ";
            info += SalesInfo;
            return info;
        }
    }

    public class PurchaseAccount : Account
    {
        public string? PurchaseInfo{get; set;}
        public string GetPurchaseAccountDetails()
        {
            string info = string.Empty;
            info += base.GetAccountDetails();
            info += "I am from Purchase Derived Class. ";
            info += PurchaseInfo;
            return info;
        }
    }
}