using System;

// some notes:
// C# data types
// - byte 0-255
// - short -32,768 - 32,767
// - int -2.1billion - 32.billion
// - long ...even bigger
// - float ... massive but with decimal --> tell c# compiler to treat it like a float, do: float number = 22.04f
// - decimal ...even more massive, with decimal obv --> must be appended with m, like float with f
// - char (unicode characters)
// - bool (boolean)
// - above are primitive types, NON-primitive types include:
// - string
// - array
// - enum
// - class

// "checked" keyword prevents overflow at runtime; an exception will be thrown/program will crash unless exception is handled

// SCOPE: block

// keyword var: can make variable declaration easier, it essentially allows c# compiler to detect data type, rather than
// having to declare it explicitly --> int count = 10; vs. var count = 10; depends on HOW specific you want to be...

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte number;
            //number = 1;
            //int count = 10;
            //float totalPrice = 20.95f;
            //char character = 'A';  // char gets single quotes
            //string firstName = "Katie"; // string gets double quotes
            //bool isWorking = true;
            //var newNum = 13;
            //var word = "piano";


            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //const float Pi = 3.14f;
            //Console.WriteLine(Pi);

        }
    }
}
