using System;
using System.Collections.Generic;
using System.Text;

namespace thereseWebPage.Core.DomainModel
{
   public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Links { get; set;  }

        public Project(string title, string description, string links)
        {
            Title = title;
            Description = description;
            Links = links;
        }
    }
}
