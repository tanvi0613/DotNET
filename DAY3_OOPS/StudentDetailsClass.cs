namespace OopsSessions
{
    public class School
    {
        public int id;
        public string? name;
        public string? address;
    }
    public class HighSchoolStudent
    {
        public int id;
        public string? name;
        public string? grade;
    }

    public class UGStudent
    {
        public int id;
        public string? name;
        public string? branch;
    }

    public class PGStudent
    {
        public int id;
        public string? name;
        public string? branch;
    }

    public class StudentDetails
    {
        public School? SchoolDetails;
        public HighSchoolStudent? HSStudentDetails;
        public UGStudent? UGStudentDetails;
        public PGStudent? PGStudentDetails;
    }

    public class AllDetails
    {
        StudentDetails[] allDetails = new StudentDetails[10];
    }
}