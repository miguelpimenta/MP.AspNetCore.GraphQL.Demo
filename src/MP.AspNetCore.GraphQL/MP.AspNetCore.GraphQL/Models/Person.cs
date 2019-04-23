using System;

namespace MP.AspNetCore.GraphQL.Models
{
    public class Person
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }

        private Role Role { get; set; }
    }
}