using System;
using System.Collections.Generic;
using System.Text;

namespace thereseWebPage.Core.DomainModel
{
    public class ProjectList
    {
        public IEnumerable<Project> Projects { get; }

        public ProjectList(IEnumerable<Project> projects)
        {
            Projects = projects;
        }
    }
}
