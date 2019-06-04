using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Business
{
    public class SharePost
    {
        Post post = new Post();

        public String OriginalPost()
        {
            
            post.PostID = 1;
            post.Subject = "Blast Asia Trainees";
            post.PostBody = "Kaya natin to, hotdog tayo!";
            post.Author = "Kayla Capito";
            post.DateCreated = DateTime.Now;
            return String.Format(post.GetDetails());
            
        }
        public string ClonePost()
        {

            Post postcopy = (Post)post.Clone();
            postcopy.Author = "Charles Kenichi";
            postcopy.PostBody += "yeah yeah yeah";
            return String.Format(postcopy.GetDetails());
        }


    }
}
