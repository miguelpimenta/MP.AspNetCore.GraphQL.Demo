using MP.AspNetCore.GraphQL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.AspNetCore.GraphQL.Data
{
    public class RoleRepository : IRoleRepository
    {
        private List<Role> _roles;

        public RoleRepository()
        {
            _roles = new List<Role>{
                new Role()
                {
                    Id = 1,
                    Description = "Student"
                },
                new Role()
                {
                    Id = 2,
                    Description = "Professor"
                }
            };
        }

        public Task<List<Role>> RolesAsync()
        {
            return Task.FromResult(_roles);
        }

        public Task<Role> GetRoleAsync(int id)
        {
            return Task.FromResult(_roles.FirstOrDefault(x => x.Id == id));
        }
    }
}