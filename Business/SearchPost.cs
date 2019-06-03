using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Linq;
namespace Business
{
    class SearchPost
    {
        public List<Post> postList = new List<Post>();
        public void postlist(string x)
        {
            var searchresult = from result in postList
                               where result.Subject.Contains(x) || result.PostBody.Contains(x) || result.Author.Contains(x)
                               select new
                               {
                                   result.Subject,
                                   result.PostBody
                               };
        }
    }
}
