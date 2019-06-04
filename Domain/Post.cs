using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Post : Entity, ICloneable
    {
        public int PostID { get; set; }
        public String Subject { get; set; }
        public String PostBody { get; set; }
        public String Author { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public string GetDetails()
        {
            return string.Format("Subject: {0} \nBody: {1} \nAuthor: {2} \nDateCreated: {3}", Subject, PostBody, Author, DateCreated);
        }
    }
}
