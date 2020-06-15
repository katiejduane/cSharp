using System;
using Classes.People;
using Classes.Math;

// you must allocate memory for classes with the 'new' keyword. however, unlike in other langs such as C++ you do not have to worry
// about de-allocating the memory, CLR (common language runtime) will take care of it for you by "garbage collection" which removes
// all unused objects at runtime.

// access properties on an object with dot notation!

// declare as PUBLIC or PRIVATE

// a STATIC method can be accessed FROM a class alone, it does not need to be instantiated as an object to be used; in fact, we
// cannot access static methods from object; it saves memory, as it's located on one class on not all its instantiated objects

namespace Classes
    // we cannot creates classes within Main(), but at the namespace level, but one class per file, we don't wan't multiple in one file!
    // remember relaetd CLASSES should be grouped by namespaces, so classes about PEOPLE could be in a namespace called PersonClasses
    // and classes related to animals could be grouped together in a namespace called AnimalClasses (lame examples but you get the point)
    // see example files in this section for naming conventions
{

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}

// there are also things called Structs (structures) in C#; very similar to a class, the only difference is instead of using class keyword
// use 'struct' keyword. there are lots of tiny differences between classes and structs. Use a structure when you wanto develop a small
// light weight object.
