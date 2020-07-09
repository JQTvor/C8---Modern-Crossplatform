﻿using System;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;

            //loop through the assemblies that this app reference
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                //load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));

                //declare a variable to count the number of methods
                int methodCount = 0;

                //Loop through all the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    //add up all the counts of methods
                    methodCount += t.GetMethods().Count();
                }

                //Ouput the count of types and their methods
                Console.WriteLine("{0:N0} types with {1:N0} method in {2} assembly.",
                arg0: a.DefinedTypes.Count(),
                arg1: methodCount,
                arg2: r.Name);

            }
        Console.ReadLine();
        }

        
    }
}
