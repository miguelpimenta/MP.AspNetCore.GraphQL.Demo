using MP.AspNetCore.GraphQL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.AspNetCore.GraphQL.Data
{
    public class PersonRepository : IPersonRepository
    {
        private List<Person> _persons;

        public PersonRepository()
        {
            _persons = new List<Person>{
                new Person()
                {
                    Id = 1,
                    RoleId = 2,
                    Name = "John Smith",
                    BirthDate = new System.DateTime(1985, 01, 01),
                    Description = "Someone...",
                },
                new Person()
                {
                    Id = 2,
                    RoleId = 1,
                    Name = "Donald Trump",
                    BirthDate = new System.DateTime(1960, 01, 01),
                    Description = "An alien...",
                },
                new Person()
                {
                    Id = 3,
                    RoleId = 1,
                    Name = "Chuck Norris",
                    BirthDate = new System.DateTime(1965, 01, 01),
                    Description = "80's/90's Action hero",
                }
            };
        }

        public Task<Person> GetPersonAsync(int id)
        {
            return Task.FromResult(_persons.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Person>> GetPersonsAsync()
        {
            return Task.FromResult(_persons);
        }

        public Task<List<Person>> GetPeronsWithByRoleIdAsync(int roleId)
        {
            return Task.FromResult(_persons.Where(x => x.RoleId == roleId).ToList());
        }
    }
}