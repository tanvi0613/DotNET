namespace OopsSessions
{
    public class Competition
    {
        #region Declaration
        public int compId;
        public string compName;
        public string empName;
        public int rank;
        #endregion

        #region Constructor
        public Competition()
        {
            compId = 1;
            empName = string.Empty;
            compName = string.Empty;
            rank = 1;
        }
        #endregion

        #region Member Functions
        /// <summary>
        /// This is assigning the Competition details to class variables
        /// </summary>
        /// <param name="id">Input Competition Id</param>
        /// <param name="name">Input Competition name</param>
        public void SetCompetitionDetails(int compId, string empName, string compName, int rank)
        {
            this.compId = compId;
            this.empName = empName;
            this.compName = compName;
            this.rank = rank;
        }

        /// <summary>
        /// This return the Competition deatils
        /// </summary>
        /// <returns>Competition Details</returns>
        public string GetCompetitionDetails()
        {
            return "Competition Id: " + compId + "Competiton Name: " + compName + "Employee name: " + empName + "Rank: " + rank;
        }
        #endregion
    }
}