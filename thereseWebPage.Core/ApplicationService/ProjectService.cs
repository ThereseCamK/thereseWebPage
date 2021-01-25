using System;
using System.Collections.Generic;
using System.Text;
using thereseWebPage.Core.DomainModel;
using thereseWebPage.Core.DomainService;

namespace thereseWebPage.Core.ApplicationService
{
    public class ProjectService
    {
        private readonly IProjectsRepository _projects;

        public ProjectService(IProjectsRepository projects)
        {
            _projects = projects;
        }

        public bool AddNewProject(Project addNew)
        {
            return _projects.Create(addNew);
        }

        public ProjectList GetProjects()
        {
            var allProjects = _projects.ReadAll();
            return allProjects;
        }
    }
}
