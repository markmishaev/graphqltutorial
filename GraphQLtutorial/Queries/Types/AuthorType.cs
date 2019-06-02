﻿using GraphQLtutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLtutorial.Queries.Types
{
    public class AuthorType : GraphQL.Types.ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(x => x.Id).Description("Id of an author");
            Field(x => x.Name).Description("Name of an author");
            Field(x => x.Bio).Description("Bio description of an author");
            Field(x => x.ImgUrl).Description("Url of an author's profile picture");
            Field(x => x.ProfileUrl).Description("Link of an author's profile");
        }
    }
}