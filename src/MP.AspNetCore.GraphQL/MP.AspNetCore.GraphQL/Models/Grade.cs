using System;

namespace MP.AspNetCore.GraphQL.Models
{
    public class Grade
    {
        public int GradeId { get; set; } = 0;
        public int StudentId { get; set; } = 0;
        public int CourseUnitId { get; set; } = 0;
        public DateTime GradeDate { get; set; } = DateTime.Now;
        public float GradeValue { get; set; } = 0;
    }
}