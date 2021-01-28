using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using thereseWebPage.Core.ApplicationService;
using thereseWebPage.Core.DomainModel;
using thereseWebPage.UserInterface.Model;

namespace thereseWebPage.UserInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _blogService;

        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpPost]
        public void Post(BlogViewModel blogView)
        {
            var addNew = new Blog(
                blogView.HeadLine,
                blogView.BlogContent,
                blogView.Picture,
                blogView.PublishedDate

                );
            _blogService.AddNewBlog(addNew);
        }

        [HttpGet]
        public ActionResult<BlogList> Get()
        {
            return _blogService.GetBlogs();
        }

    }



}
