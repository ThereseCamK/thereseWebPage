using System;
using System.Collections.Generic;
using System.Text;
using thereseWebPage.Core.DomainModel;
using thereseWebPage.Core.DomainService;

namespace thereseWebPage.DataAccess
{
    public class BlogInMemoryRepository : IBlogRepository
    {

        private List<Blog> _blog;

        public BlogInMemoryRepository()
        {
            _blog = new List<Blog>();
        }

        public bool Create(Blog blog)
        {
            _blog.Add(blog);
            return true;
        }

        public BlogList ReadAll()
        {
            
            return new BlogList(_blog);
        }
    }
}
