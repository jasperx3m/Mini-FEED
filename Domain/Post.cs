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
        
    }
}
