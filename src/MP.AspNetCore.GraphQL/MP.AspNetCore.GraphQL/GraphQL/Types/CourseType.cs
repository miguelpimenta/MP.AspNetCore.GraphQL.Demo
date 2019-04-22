using GraphQL.Types;
using System.Linq;

namespace MP.AspNetCore.GraphQL.GraphQL.Types
{
    public class CourseType : ObjectGraphType<CourseType>
    {
        public CourseType(IPersonRepository productRepository)
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