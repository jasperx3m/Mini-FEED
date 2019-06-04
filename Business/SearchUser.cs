using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Linq;
namespace Business
{
    class SearchUser
    {
        List<User> userList = new List<User>();
        public void postlist(string  x)
        {
            var searchresult = from result in userList
                               where (result.FirstName.Contains(x) || result.LastName.Contains(x) || result.Email.Contains(x) || result.Birthday.Equals(x) || result.Age.Equals(x))
                               select new
                               {
                                   result.FirstName,
                                   result.LastName,
                                   result.Email,
                                   result.Birthday,
                                   result.Age
                               };
        }
    }
}
