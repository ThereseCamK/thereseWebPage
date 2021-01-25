using System;
using System.Collections.Generic;
using System.Text;
using thereseWebPage.Core.DomainModel;

namespace thereseWebPage.Core.DomainService
{
    public interface IProjectsRepository
    {
        bool Create(Project projs);
        ProjectList ReadAll();
    }
}
