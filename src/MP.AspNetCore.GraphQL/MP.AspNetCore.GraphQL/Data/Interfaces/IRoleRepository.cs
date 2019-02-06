using MP.AspNetCore.GraphQL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MP.AspNetCore.GraphQL.Data
{
    public interface IRoleRepository
    {
        Task<List<Role>> RolesAsync();

        Task<Role> GetRoleAsync(int id);
    }
}