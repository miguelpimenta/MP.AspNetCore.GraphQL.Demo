using System;

namespace MP.AspNetCore.GraphQL.Models
{
    public class Course
    {
        public int Id { get; set; } = 0;
        public int AreaId { get; set; } = 0;
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int[] CourseUnit { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
    }
}