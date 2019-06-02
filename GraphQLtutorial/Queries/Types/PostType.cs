using GraphQLtutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace GraphQLtutorial.Queries.Types
{
    public class PostType : GraphQL.Types.ObjectGraphType<Post>
    {
        public PostType()
        {
            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.Url);
            Field(x => x.Date);
            Field(x => x.Description);
            Field<AuthorType>("author");
            Field<RatingType>("rating");
            Field<ListGraphType<CommentType>>("comments");
            Field(x => x.Categories, nullable: true);
        }
    }
}
