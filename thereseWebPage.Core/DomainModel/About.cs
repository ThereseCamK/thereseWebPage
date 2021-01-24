using System;
using System.Collections.Generic;
using System.Text;

namespace thereseWebPage.Core.DomainModel
{
    public class About
    {
        public string AboutMe { get; }

        public About(string aboutMe)
        {
            AboutMe = aboutMe;
        }
    }
}
