using System;

// Type Conversion
// example of IMPLICIT type conversion --> it will happen automatically if there is no data loss, you need to explicity tell the compiler (EXplicit)
// byte b = 1;
// int i = b;
// example of EXPLICIT type conversion -->
// int i = 1;
// byte b = (byte)i --> this tells c# you know data loss will happen and do not care; called TYPE CASTING
// NON-Compatible types
// string s = "1";
// int i = Convert.ToInt31(s); // (part of .NET framework and part of system namespace) OR
// int j = int.Parse(s) // all primitive types have access to the .Parse() method

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1000;
            //byte b = (byte)i; // this cannot be converted implicitly (data loss), so must declare type explicitly
            //// if value exceeds allowable amount by type, some data will be lost, as in 1000 --> 232
            //Console.WriteLine(b);

            //string number = "1234";
            ////int i = (int)number; // won't work!
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            //var number = "1234";
            //byte b = Convert.ToByte(number);
            //Console.WriteLine(b); // will throw exception and crash program! sooo... try/catch

            //try
            //{
            //    var number = "1234";
            //    byte b = Convert.ToByte(number);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Number could not be converted to a byte");
            //    //throw;
            //}

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("could not convert to boolean");
            }

        }
    }
}
