using System;
// declaring an array: int[] numbers = new int[3];
// you must declare length of array when you create it, and allocate memory by using the 'new' keyword. it an obejct behind the scene!
// this is why we need to allocate memory for it! :)
// in C# arrays ARE 0 indexed
// if you know what the elements of each array index, you can add them all at once instead of numbers[0] = 1; by using:
// int[] numbers = new int[3]{1,2,3};
// if you do not declare an index, it will default to 0 (for ints), for booleans, defaults to false

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "bobby", "jack", "mary" };
            Console.WriteLine(names[0]);
        }
    }
}
