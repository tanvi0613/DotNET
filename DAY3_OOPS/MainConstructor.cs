using OopsSessions.ConstructorEx;

namespace OopsSessions
{
    public class MainConstructor
    {
        public static void Main(string[] args)
        {
            #region Function
            Visitor visitor = new Visitor();
            Visitor visitor1 = new Visitor(10, "Tanvi", "DSA");

            ///Customized the constructor to do validations before storing the object values
            //try
            // {
            //     Visitor visitor2 = new Visitor(20,"HeLLoTanvi");
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            #endregion


            // Practice prac = new Practice(5,10);
            // Console.WriteLine(prac.Result);
        }
    }
}