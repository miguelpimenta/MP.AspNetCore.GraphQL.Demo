using GraphQL.Types;
using System;

namespace MP.AspNetCore.GraphQL.Models.Schemas
{
    public class PersonsSchema : Schema
    {
        public PersonsSchema(Func<System.Type, GraphType> resolveType) : base(resolveType)
        {
            Query = (PersonsQuery)resolveType(typeof(PersonsQuery));
        }
    }
}