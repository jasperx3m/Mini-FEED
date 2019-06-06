using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public partial class User : Entity, ICloneable
    {
        public int UserID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public int Age { get; set; }
        public String Password { get; set; }

        public object Clone()
        {
            User userclone;
            userclone = (User)this.Clone();
            userclone.BirthdayDetails = (Birthday)BirthdayDetails.Clone();
            return userclone;
        }


        //public override string ToString()
        //{
        //    return string.Format("ID: {0} \nFirst Name: {1} \nLast Name: {2} \nEmail: {3} \nBirthday: {4} \nAge: {5}",this.UserID,this.FirstName,this.LastName,this.Email,this.Birthday,this.Age);
        //}


    }
    public partial class User
    {
        public Birthday BirthdayDetails { get; set; }
    }
    public class Birthday : ICloneable
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
