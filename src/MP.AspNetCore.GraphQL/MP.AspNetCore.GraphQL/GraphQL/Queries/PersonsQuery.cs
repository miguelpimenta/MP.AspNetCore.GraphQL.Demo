using GraphQL.Types;
using MP.AspNetCore.GraphQL.Data;

namespace MP.AspNetCore.GraphQL.Models
{
    public class PersonsQuery : ObjectGraphType
    {
        public PersonsQuery(IRoleRepository roleRepository, IPersonRepository personsRepository)
        {
            Field<RoleType>(
                "role",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Role id" }
                ),
                resolve: context => roleRepository.GetRoleAsync(context.GetArgument<int>("id")).Result
            );

            Field<PersonType>(
                "person",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Person id" }
                ),
                resolve: context => personsRepository.GetPersonAsync(context.GetArgument<int>("id")).Result
            );
        }
    }
}