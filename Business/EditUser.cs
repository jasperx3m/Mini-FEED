using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Business
{
    class EditUser
    {
        List<User> userList = new List<User>();
        public void edituser(string fname, string lname, string email, string bday, int age, int id)
        {
            userList.Find(post => post.UserID == id).FirstName = fname;
            userList.Find(post => post.UserID == id).LastName = lname;
            userList.Find(post => post.UserID == id).Email = email;
            userList.Find(post => post.UserID == id).Birthday = bday;
            userList.Find(post => post.UserID == id).Age = age;
        }
    }
}
