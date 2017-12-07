using DynamicRest.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicRest.Middlewares.GraphQL.Types
{
    public class GroupType: ObjectGraphType<GroupInfo>
    {
        public GroupType()
        {
            Field(x => x.Id).Description("the group Id");
            Field(x => x.Name).Description("The name of the group");
            Field<ListGraphType<PersonType>>("members");
        }
    }
}
