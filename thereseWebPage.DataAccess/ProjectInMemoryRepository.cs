using System;
using System.Collections.Generic;
using System.Text;
using thereseWebPage.Core.DomainModel;
using thereseWebPage.Core.DomainService;

namespace thereseWebPage.DataAccess
{
    public class ProjectInMemoryRepository : IProjectsRepository
    {
        private List<Project> _projectList;


        public ProjectInMemoryRepository()
        {
            _projectList = new List<Project>();
        }
        public bool Create(Project projs)
        {
            _projectList.Add(projs);
            return true;
        }

        public ProjectList ReadAll()
        {
            return null;
        }
    }
}
