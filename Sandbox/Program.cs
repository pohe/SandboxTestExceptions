using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertCodeHere theCode = new InsertCodeHere();

            //try
            //{
                theCode.MyCode();
            //}
            //catch (FormatException  fex)
            //{
            //    Console.WriteLine("Her samles formatexception op");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Her samles den generelle exception op");
            //}

            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
