using GraphQLtutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace GraphQLtutorial.Queries.Types
{
    public class SocialNetworkType : GraphQL.Types.ObjectGraphType<SocialNetwork>
    {
        public SocialNetworkType()
        {
            Field(x => x.NickName);
            Field<EnumerationGraphType<SNType>>("type");
            Field(x => x.Url);
            Field<AuthorType>("author");
        }
    }
}
