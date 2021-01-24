using System;
using System.Collections.Generic;
using System.Text;

namespace thereseWebPage.Core.DomainModel
{
   public class Projects
    {
        public string Title { get; }
        public string Description { get; }
        public string Links {get;}

        public Projects(IEnumerable<Projects> allProjects)
        {
            
        }
        public Projects(string title, string description, string links)
        {
            Title = title;
            Description = description;
            Links = links;
        }
    }
}
