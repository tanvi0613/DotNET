namespace OopsSessions
{
    public class Person
    {
        public Person()
        {
            id=0;
            name = string.Empty;
            age=0;
        }
        public int id;
        public string? name;
        public int age;
    }

    public class Man : Person
    {
        public Man()
        {
            id=0;
            name = string.Empty;
            age=0;
            Playing = "";
        }
        public string? Playing;
    }

    public class Woman : Person
    {
        public Woman()
        {
            id=0;
            name = string.Empty;
            age=0;
            PlayAndManage = "";
        }
        public string? PlayAndManage;
    }

    public class Child : Person
    {
        public string? WatchingCartoon;
    }
}