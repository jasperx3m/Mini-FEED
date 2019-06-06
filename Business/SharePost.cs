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
        List<Post> feed = new List<Post>();
        PostRepo postrepo = new PostRepo();

        public void OriginalPost(string author)
        {

            feed.Add(
            new Post
            {
                PostID = feed.Count,
                Subject = "Blast Asia Trainees",
                PostBody = "Go Blasters!!!",
                Author = author,
                DateCreated = DateTime.Parse("06/02/2019 8:55:02")
            });
        }
        public void ClonePost(int id,string author)
        {

            Post postcopy = (Post)feed[id].Clone();
            postcopy.Author = author;
            postcopy.PostBody += "\nby: "+feed[id].Author+"\nyeah yeah yeah";
            postcopy.DateCreated = DateTime.Now;
            postrepo.AddPost(postcopy);
            feed.Add
                (
                new Post
                {
                    PostID = feed.Count,
                    Subject = postcopy.Subject,
                    PostBody= postcopy.PostBody,
                    Author=postcopy.Author,
                    DateCreated=postcopy.DateCreated
                }
                ); 
        }
        public void GetDetails()
        {
            foreach (var i in feed)
            {
                Console.WriteLine("Subject: {0} \nBody: {1} \nAuthor: {2} \nDateCreated: {3} \nPostID:{4}\n", i.Subject, i.PostBody, i.Author, i.DateCreated, i.PostID);
            }

        }



    }
}
