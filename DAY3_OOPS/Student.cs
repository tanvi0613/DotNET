namespace OopsSessions
{
    /// <summary>
    /// Class to Store details of students
    /// </summary>
    public class Student
    {
        #region Declaration
        public int id;
        public string name;
        #endregion

        #region Constructor
        public Student() //ctor
        {
            id = 1;
            name = string.Empty;
        }
        #endregion

        #region Member functions
        /// <summary>
        /// To initialize the name variable created in class
        /// </summary>
        /// <param name="name">Input to store name</param>
        public void SetDetails(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        /// <summary>
        /// Returning the name 
        /// </summary>
        /// <returns></returns>
        public string GetDetails()
        {
            return "Id: " + id + "Name: " + name;
        }
        #endregion
    }
}