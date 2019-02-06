using GraphQL.Types;
using MP.AspNetCore.GraphQL.Data;
using System.Linq;

namespace MP.AspNetCore.GraphQL.Models
{
    public class RoleType : ObjectGraphType<Role>
    {
        public RoleType(IPersonRepository productRepository)
        {
            Field(x => x.Id).Description("Role id.");
            Field(x => x.Description, nullable: true).Description("Role Description.");

            Field<ListGraphType<PersonType>>(
                "persons",
                resolve: context => productRepository.GetPeronsWithByRoleIdAsync(context.Source.Id).Result.ToList()
            );
        }
    }
}