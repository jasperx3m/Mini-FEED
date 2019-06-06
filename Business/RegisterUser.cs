using System;
using System.Collections.Generic;
using Domain;
namespace Business
{
    public class RegisterUser
    {
        public void register(string fname,string lname, string email, string bday, int age, int id)
        {
            List<User> userList = new List<User>();
            userList.Add(new User { UserID = id, FirstName = fname, LastName = lname, Email = email, Age = age});
        }
    }
    
}
