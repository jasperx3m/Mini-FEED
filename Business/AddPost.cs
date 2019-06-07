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
            
            List<Post> feed = new List<Post>();
            feed.Add(new Post { Subject = subject, PostBody = body, PostID = feed.Count });
        }
        abstract class PostBuilder
        {
            public abstract void BuildSubject();
            public abstract void BuildBody();
            public abstract void BuildAuthor();
            
        }
        class Director
        {
            public void ConstructPost(PostBuilder builder)
            {
                builder.BuildSubject();
                builder.BuildBody();
                builder.BuildAuthor();
            }
        }
        class ConcretePost : PostBuilder
        {
            private Post _post=new Post();
            public override void BuildAuthor()
            {
                throw new NotImplementedException();
            }

            public override void BuildBody()
            {
                throw new NotImplementedException();
            }

            public override void BuildSubject()
            {
                throw new NotImplementedException();
            }
        }


    }
}
