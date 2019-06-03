using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Repos
{
    class Users
    {
        public List<User> userList = new List<User>();
            public void initialUser()
            {
                userList.Add(new User { UserID = 1, FirstName = "Jasper", LastName = "Orilla", Email = "jasper@gmail.com", Birthday = "09/15/1996", Age = 20 }); ;
            }
        
    }
}
