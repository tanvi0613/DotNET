namespace OopsSessions
{
    public class Employee
    {
        #region Declaration
        public int empId;
        public string empName;
        public string designation;
        #endregion

        #region Constructor
        public Employee()
        {
            empId = 1;
            empName = string.Empty;
            designation = string.Empty;
        }
        #endregion

        #region Member Functions
        /// <summary>
        /// This is assigning the employee details to class variables
        /// </summary>
        /// <param name="id">Input Employee Id</param>
        /// <param name="name">Input Employee name</param>
        /// <param name="designation">Input Employee designation</param>
        public void SetEmployeeDetails(int empId, string empName, string designation)
        {
            this.empId = empId;
            this.empName = empName;
            this.designation = designation;
        }

        /// <summary>
        /// This return the employee deatils
        /// </summary>
        /// <returns>Employee Details</returns>
        public string GetEmployeeDetails()
        {
            return "Id: " + empId + "Name: " + empName + "Designation: " + designation;
        }
        #endregion
    }
}