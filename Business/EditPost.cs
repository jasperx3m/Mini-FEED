using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Business
{
    class EditPost
    {
        public List<Post> postList = new List<Post>();
        public void editpost(int id, string subject, string body, string author)
        {
            postList.Find(post => post.PostID == id).Subject =subject;
            postList.Find(post => post.PostID == id).PostBody = body;
            postList.Find(post => post.PostID == id).Author= author;
        }
    }
}
