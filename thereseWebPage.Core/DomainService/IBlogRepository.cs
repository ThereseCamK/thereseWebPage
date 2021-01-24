using System;
using System.Collections.Generic;
using thereseWebPage.Core.DomainModel;

namespace thereseWebPage.Core
{
    public interface IBlogRepository
    {
        bool Create(Blog blog);
        IEnumerable<Blog> ReadAll();

    }
}
