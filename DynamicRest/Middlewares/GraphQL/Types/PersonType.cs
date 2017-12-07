using DynamicRest.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicRest.Middlewares.GraphQL.Types
{
    public class PersonType: ObjectGraphType<PersonInfo>
    {
        public PersonType()
        {
            Field(x => x.Id).Description("the person Id");
            Field(x => x.Name).Description("the person full name");
            Field(x => x.Contact).Description("the person contact");
            Field(x => x.Address).Description("the person address");
        }
    }
}
