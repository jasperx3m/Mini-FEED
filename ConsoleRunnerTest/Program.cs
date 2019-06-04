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
            Console.WriteLine(sp.OriginalPost());
            Console.WriteLine("\n");
            Console.WriteLine("Shared Post");
            Console.WriteLine(sp.ClonePost());


        }
    }
}
