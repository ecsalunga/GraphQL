using DynamicRest.Middlewares.GraphQL.Types;
using DynamicRest.Storage;
using GraphQL.Types;
using System.Linq;

namespace DynamicRest.Middlewares.GraphQL.Query
{
    public class RepositoryQuery : ObjectGraphType
    {
        public RepositoryQuery(IRepository repository)
        {
            Field<PersonType>("person",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "id" }),
                resolve: context =>
                {
                    int id = context.GetArgument<int>("id");
                    return repository.GetPersonById(id);
                }
            );

            Field<ListGraphType<PersonType>>("persons",
                arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "limit" }),
                resolve: context =>
                {
                    /*
                    if(context.Arguments.ContainsKey("limit"))
                    {
                        int limit = context.GetArgument<int>("limit");
                        return repository.GetPersons().Take(limit);
                    }
                    */
                    return repository.GetPersons();
                }
            );

            Field<GroupType>("group",
               arguments: new QueryArguments(new QueryArgument<IntGraphType>() { Name = "id" }),
               resolve: context =>
               {
                   int id = context.GetArgument<int>("id");
                   return repository.GetGroupById(id);
               }
            );

            Field<ListGraphType<GroupType>>("groups",
                resolve: context =>
                {
                    return repository.GetGroups();
                }
            );
        }
    }
}
