using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thereseWebPage.UserInterface.Model
{
    public class BlogViewModel
    {
        public string BlogContent;
        public DateTime PublisedDate;
        public string HeadLine { get; }
        public object Picture { get; set; }
    }
}
