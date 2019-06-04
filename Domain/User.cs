using System;
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

        public override string ToString()
        {
            return string.Format("ID: {0} \nFirst Name: {1} \nLast Name: {2} \nEmail: {3} \nBirthday: {4} \nAge: {5}",this.UserID,this.FirstName,this.LastName,this.Email,this.Birthday,this.Age);
        }
        
    }
    
}
