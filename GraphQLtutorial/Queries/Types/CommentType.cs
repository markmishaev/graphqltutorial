using GraphQLtutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLtutorial.Queries.Types
{
    public class CommentType : GraphQL.Types.ObjectGraphType<Comment>
    {
        public CommentType()
        {
            Field(x => x.Count);
            Field(x => x.Description);
            Field(x => x.Url);
        }
    }
}
