namespace DAY4_OOPS.OopsSessions
{
     public class Family
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Family running");
        }
    }
    /// <summary>
    /// VIRTUAL KEYWORDS -> ALLOWS OTHERS TO OVERRIDE THE BASE CLASS FUNCTIONS
    /// </summary>
    public class Father
    {
        public virtual string InterestOn()
        {
            return "I like to play Cricket.";
        }
    }

    public class Son : Father
    {
        /// <summary>
        /// This is overriding the method of base class and defining it's own property
        /// </summary>
        public override string InterestOn()
        {
            return "Mobile Games";
            //return base.InterestOn();
        }
    }
}