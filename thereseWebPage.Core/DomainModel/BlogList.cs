﻿using System;
using System.Collections.Generic;
using System.Text;

namespace thereseWebPage.Core.DomainModel
{
    public class BlogList
    {
        public IEnumerable<Blog> Blogs { get; set; }

        public BlogList(IEnumerable<Blog> blogs)
        {
            Blogs = blogs;
        }
    }
}
