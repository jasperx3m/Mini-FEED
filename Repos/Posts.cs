using System;
using Domain;
using System.Collections.Generic;

namespace Repos
{
    public class PostRepo
    {
        Post p;
        public List<Post> postList = new List<Post>();
        public void AddPost (Post postcopy)
        {
            postList.Add(postcopy);
        }

    }
}
