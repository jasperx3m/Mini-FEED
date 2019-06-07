using System;
using System.Linq;
using System.Collections.Generic;
using Domain;
using Business;


namespace ConsoleRunnerTest
{
    class Program
    {

        public static void Main(string[] args)
        {
            SharePost sp = new SharePost();


            sp.OriginalPost("Aaron Custodio");
            sp.OriginalPost("Kyla Calpito");
            sp.ClonePost(0,"Charles kenichi");
            sp.GetDetails();


        }
    }
}
