namespace MP.AspNetCore.GraphQL.Models
{
    public class Student : Person
    {
        public int StudentNum { get; set; }

        public int[] Courses { get; set; }

        private Course[] CoursesList { get; set; }

        public int[] CourseUnits { get; set; }

        private CourseUnit[] CourseUnitsList { get; set; }
    }
}