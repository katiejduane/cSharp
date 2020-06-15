using System;
// many ways to devlar strings, most common is: string firstName = "Eitak";
// there is also something called string concatenation! using string.Format()
// you can also  create strings by joining arrays
// like arrays, you can access indices of string, like name[0] or whatever
// in C# strings are IMMUTABLE! so if name[0] == "E", we cannot changed it by swriting name[0] = "M";

/* 

escape chars for strings -->
\n = new line
\t = tab
\\ = backslash
\' = single quote
\" = doubele quote

Verbatim String --> (helpful when you want or need to use special chars) prefix with @, as in:
string path = @"c:\projects\project1\folder1";

string name = "Katie" --> C#
String name = "Katie" --> .NET framework String class from the System namespace, so if you want to do this, must put using System; at top of file
*/



namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = "Eitak";
            var lastname = "Enaud";
            string myName = string.Format("My name is {0} {1}", firstname, lastname); // concatenation
            Console.WriteLine(myName);

            var numbers = new int[3] { 1, 2, 3 };
            var list = string.Join(",", numbers);
            Console.WriteLine(list);

            var names = new string[3] { "jack", "jon", "milly" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths for the file:
c:\projects\folder1
c:\projects\folder2";
            Console.WriteLine(text);

        }
    }
}
