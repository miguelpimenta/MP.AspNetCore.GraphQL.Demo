using GraphQL.Types;
using MP.AspNetCore.GraphQL.Data;

namespace MP.AspNetCore.GraphQL.Models
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType(IRoleRepository roleRepository)
        {
            Field(x => x.Id).Description("Person Id.");
            Field(x => x.Name).Description("Person Name.");
            Field(x => x.Description, nullable: true).Description("Person description.");
            Field(x => x.BirthDate).Description("Person BirthDate.");

            Field<RoleType>(
                "role",
                resolve: context => roleRepository.GetRoleAsync(context.Source.RoleId).Result
             );
        }
    }
}