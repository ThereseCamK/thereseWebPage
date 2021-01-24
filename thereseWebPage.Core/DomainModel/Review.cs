using System;
using System.Collections.Generic;
using System.Text;

namespace thereseWebPage.Core.DomainModel
{
   public class Review
   {
       public int Rating;
       public string Comment { get; }
       public string Name { get; }

       public Review(int rating, string comment, string name)
       {
           Rating = rating;
           Comment = comment;
           Name = name;
       }
   }
}
