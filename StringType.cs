using System;
public class StringType
    {
        public static void Main(string [] args)
        {
            //escape sequences is backslash(\)
            string s = "\"Michal\"";
            string n = "One\nTwo\nThree";
            string c = "C:\\hello\\world";

            //Verbatim Literal
            string d = @"C:\\hello\\world";

            Console.WriteLine(s);
            Console.WriteLine(n);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }

