using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Linq;

namespace Business
{
    class DeletePost
    {
        public List<Post> postList = new List<Post>();
        public void deletepost(int id)
        {
            postList.Remove(postList.Find(post => post.PostID == id));
        }
    }
}
