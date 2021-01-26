using System;
using System.Collections.Generic;
using thereseWebPage.Core.DomainModel;

namespace thereseWebPage.Core.DomainService
{
    public interface IBlogRepository
    {
        bool Create(Blog blog);
        BlogList ReadAll();

    }
}
