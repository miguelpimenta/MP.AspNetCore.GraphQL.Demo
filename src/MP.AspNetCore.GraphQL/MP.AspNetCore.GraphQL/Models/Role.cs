using System.Collections.Generic;

namespace MP.AspNetCore.GraphQL.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Description { get; set; }

        private List<Person> Persons { get; set; }
    }
}