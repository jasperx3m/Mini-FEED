﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class User : Entity
    {
        public int UserID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Birthday { get; set; }
        public int Age { get; set; }
        public String Password { get; set; }
    }
    
}
