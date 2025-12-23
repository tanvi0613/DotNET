namespace OopsSessions.ConstructorEx
{
    public class Visitor
    {
        public int Id {get; set;}
        public string? Name {get; set;}
        public string? Requirements {get; set;}

        public string LogHistory {get; set;}
        
        public Visitor()
        {
            LogHistory += $"Object is created at: {DateTime.Now.ToString()}   {Environment.NewLine}";
        }

        public Visitor(int id) : this()
        {
            LogHistory += $"Id is created at: {DateTime.Now.ToString()}   {Environment.NewLine}";
            this.Id = id;
        }

        /// <summary>
        /// Customizing the constructor
        /// </summary>
        /// <param name="id">Input id</param>
        /// <param name="name">Input name</param>
        /// <exception cref="ArgumentException">Validation to not have "hello" in name</exception>
        public Visitor(int id, string name) : this(id)
        {
            if (name.ToLower().Contains("hello"))
            {
                throw new ArgumentException("Do not type hello in name");
            }
            
            LogHistory += $"Name is created at: {DateTime.Now.ToString()}   {Environment.NewLine}";
            this.Name=name;
        }

        /// <summary>
        /// Inititalizing values but also when we will run the code the pointer will come to this constructor and will be directed to previous one
        /// due to this(id,name) and then previous one, as id and name will be set in previous ones so we won't have to set them here again
        /// </summary>
        /// <param name="requirements"></param>
        public Visitor(int id, string name, string requirements) : this(id,name)
        {
            LogHistory += $"Requirements is created at: {DateTime.Now.ToString()}   {Environment.NewLine}";
            this.Requirements=requirements;
        }
    }
}