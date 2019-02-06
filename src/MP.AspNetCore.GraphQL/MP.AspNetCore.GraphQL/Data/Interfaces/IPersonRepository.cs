using MP.AspNetCore.GraphQL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MP.AspNetCore.GraphQL.Data
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetPersonsAsync();

        Task<List<Person>> GetPeronsWithByRoleIdAsync(int roleId);

        Task<Person> GetPersonAsync(int id);
    }
}