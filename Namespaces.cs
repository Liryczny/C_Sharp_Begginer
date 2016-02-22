using System;
//alias directives
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

//Could use that
//using System.Collections;
//using System.Configuration;
    public class Namespaces
    {
        public static void Main(string[] args)
        {
            PATA.ClassA.Print();
            PATB.ClassA.Print();
        }
    }

    namespace ProjectA
    {
        namespace TeamA
        {
            class ClassA
            {
                public static void Print()
                {
                    Console.WriteLine("Team A Print Method");
                }
            }
        }
    }

    namespace ProjectA
    {
        namespace TeamB
        {
            class ClassA
            {
                public static void Print()
                {
                    Console.WriteLine("Team B Print Method");
                }
            }
        }
    }

