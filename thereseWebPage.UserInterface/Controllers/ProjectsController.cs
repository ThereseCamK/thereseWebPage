using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using thereseWebPage.Core.ApplicationService;
using thereseWebPage.Core.DomainModel;
using thereseWebPage.UserInterface.Model;

namespace thereseWebPage.UserInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectService _projectService;

        public ProjectsController(ProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpPost]
        public void Post(ProjectViewModel project)
        {
            var addNew = new Project(
               project.Title, 
               project.Description,
               project.Link
            );
            _projectService.AddNewProject(addNew);
        }

        [HttpGet]
        public ActionResult<ProjectList> Get()
        {
            return _projectService.GetProjects();
        }
    }
}
