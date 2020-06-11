using System;

// in C# we have 5 types of operators!
// - arithmetic (add +, subtract -, multiply *, divide /, remainder %, increment ++, decrement ++)
    // int a = 1;
    // int b = a++;
    // result --> a = 2, b = 1 (postfix increment) --> FIRST the value of a is assigned to be, THEN a is incremented
    // int a = 1;
    // int b = ++a;
    // result --> a = 2, b = 2 (prefix increment) --> first a is incremented, then its value is assigned to b
// - comparison (equal ==, not equal !=, gt >, gte >=, lt < ,lte <=)
// - assignment ( assignment =, addition assignment +=, subtraction assignment -=, mult *=, div /=)
    // a += 3 --> a = a + 3
// - logical (And &&, Or ||, Not !)
// - bitwise (And &, Or |) --> low level programming, like w/ windows API or sockets

/*
 ooooohhhhh multi-line comments! i should have been using these... from here on out... i forgot! :D
 */

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 1;
            var d = 2;
            var e = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a / b);
            //Console.WriteLine((float)a / (float)b);
            //Console.WriteLine(c + d * e); // multiply and divide take precedence, to avoid this, use parentheses!
            //Console.WriteLine((c + d) * e);

            Console.WriteLine(a > b); // result of comparison expression is always a boolean
            Console.WriteLine(!(a != b ));
            Console.WriteLine(c > b && c > a);

        }
    }
}
