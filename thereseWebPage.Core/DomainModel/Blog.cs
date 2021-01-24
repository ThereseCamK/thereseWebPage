using System;
using System.Collections.Generic;
using System.Text;

namespace thereseWebPage.Core.DomainModel
{
   public class Blog
   {
       public string HeadLine { get; }
       public string BlogContent { get; }
       public object Picture { get; }
       public DateTime PublishedDate { get; }

       public Blog()
       {
           
       }
       public Blog(string headLine, string blogContent, object picture, DateTime publishedDate)
       {
           HeadLine = headLine;
           BlogContent = blogContent;
           Picture = picture;
           PublishedDate = publishedDate;
       }
   }
}
