using System;

namespace MP.AspNetCore.GraphQL.Models
{
    public class CourseUnit
    {
        public int Id { get; set; } = 0;
        public int AreaId { get; set; } = 0;
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Credits { get; set; } = 0;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = null;
        public bool Active { get; set; } = true;
    }
}