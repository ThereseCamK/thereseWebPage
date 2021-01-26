using System;
using System.Collections.Generic;
using System.Text;
using thereseWebPage.Core.DomainModel;
using thereseWebPage.Core.DomainService;

namespace thereseWebPage.Core.ApplicationService
{
    public class BlogService
    {
        private readonly IBlogRepository _blogs;

        public BlogService(IBlogRepository blogs)
        {
            _blogs = blogs;
        }

        public bool AddNewBlog(Blog addNew)
        {
            return _blogs.Create(addNew);
        }

        public BlogList GetBlogs()
        {
            var allBlogs = _blogs.ReadAll();
            return allBlogs;
        }
    }
}
