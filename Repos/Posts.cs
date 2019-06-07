using System;
using Domain;
using System.Collections.Generic;

namespace Repos
{
    public class PostRepo
    {
        Post post = new Post();
        public List<Post> postList = new List<Post>();
        public void AddPostCopy (Post postcopy)
        {
            postList.Add(postcopy);
        }
        public void AddPost(Post post)
        {
            postList.Add(AddPostCopy);
        }

    }
}
