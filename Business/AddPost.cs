using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Business
{
    class AddPost
    {
        public void addpost(string subject, string body, string author, int id)
        {
            List<Post> addpost = new List<Post>();
            addpost.Add(new Post { Subject = subject, PostBody = body, Author = author, PostID = id });
        }
    }
}
