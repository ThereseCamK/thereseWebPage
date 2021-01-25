using System;
using System.Collections.Generic;
using System.Text;

namespace thereseWebPage.Core.DomainModel
{
   public class Project
    {
        public string Title { get; }
        public string Description { get; }
        public string Links { get; }

        public Project(string title, string description, string links)
        {
            Title = title;
            Description = description;
            Links = links;
        }
    }
}
