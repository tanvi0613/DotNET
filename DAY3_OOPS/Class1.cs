namespace OopsSessions
{
    #region EX1
    // public class Class1
    // {
    //     /// <summary>
    //     /// Main function (or entry point)
    //     /// </summary>
    //     /// <param name="args">Console based inputs</param>
    //     public static void Main(string[] args)
    //     {
    //         Student stu = new Student();
    //         Student stu1 = new Student()
    //         {
    //             id = 1,
    //             name = "Tanvi"
    //         };

    //         stu.SetDetails(2, "Tanvi2");
    //         string name = stu.GetDetails();
    //         Console.WriteLine(name);
    //     }
    // }
    #endregion


    //INHERITANCE
    public class PeopleDetails
    {
        /// <summary>
        /// Main Function
        /// </summary>
        /// <param name="args">Console based input</param>
        public static void Main(string[] args)
        {
            PeopleDetails program = new PeopleDetails();

            // Person person = new Person(){id=10, name="Test", age=100};
            // string result = program.GetDetails(person);
            // Console.WriteLine(result);

            Man man = new Man() { id = 1, name = "Abc", age = 21, Playing = "Basketball" };
            string result2 = program.GetDetails(man);
            Console.WriteLine(result2);

            // Person woman = new Woman(){id=1, name="Tuv", age=20, PlayAndManage="Badminton And Studies"};
            // Person child = new Child(){id=2, name="Xyz", age=2, WatchingCartoon="Bluey"};
        }

        /// <summary>
        /// This is returning the details for the Person be it Person, Man, Woman or Child
        /// </summary>
        /// <param name="person">Input for person details</param>
        /// <returns>Person details</returns>
        public string GetDetails(Person person)
        {
            string result = string.Empty;
            result = $" Id = {person.id}  Name = {person.name}  Age = {person.age}";
            if (person is Man)
            {
                Man man = (Man)person; //implicit conversion of parent(Person) to child(Man)
                result = $" Id = {man.id}  Name = {man.name}  Age = {man.age}  Playing = {man.Playing}";
            }
            if (person is Woman)
            {
                Woman woman = (Woman)person;
                result = $" Id = {woman.id}  Name = {woman.name}  Age = {woman.age}  Playing = {woman.PlayAndManage}";
            }
            if (person is Child)
            {
                Child child = (Child)person;
                result = $" Id = {child.id}  Name = {child.name}  Age = {child.age}  Playing = {child.WatchingCartoon}";
            }

            return result;
        }
    }
}