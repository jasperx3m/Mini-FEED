using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Repos;

namespace Business
{
    public class SharePost
    {
        Post post = new Post();
        PostRepo postrepo = new PostRepo();
        public String OriginalPost(string author)
        {
            
            post.PostID = 1;
            post.Subject = "Blast Asia Trainees";
            post.PostBody = "Go Blasters!!!";
            post.Author = author;

            post.DateCreated = DateTime.Parse("06/02/2019 8:55:02");
            return String.Format(post.GetDetails());

            
        }
        public string ClonePost(string author)
        {

            Post postcopy = (Post)post.Clone();
            postcopy.Author = author;
            postcopy.PostBody += "\nby: "+post.Author+"\nyeah yeah yeah";
            postcopy.DateCreated = DateTime.Now;
            postrepo.AddPost(postcopy);
            return String.Format(postcopy.GetDetails());
            
        }



    }
}
