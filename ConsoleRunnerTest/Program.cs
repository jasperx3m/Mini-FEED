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
           
            
            Console.WriteLine("Original Post");
            Console.WriteLine(sp.OriginalPost("Aaron Custodio"));
            Console.WriteLine("\n");
            Console.WriteLine(sp.OriginalPost("Kyla Calpito"));
            Console.WriteLine("\n");
            Console.WriteLine("Shared Post");
            Console.WriteLine(sp.ClonePost("Charles kenichi"));

        }
    }
}
