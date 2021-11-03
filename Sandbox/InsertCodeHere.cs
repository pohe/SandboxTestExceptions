using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            string input = "";
            Console.WriteLine("Indtast tal1:");
            input = Console.ReadLine();
            int tal1 = int.Parse(input);

            Console.WriteLine("Indtast tal2:");
            input = Console.ReadLine();
            int tal2 = int.Parse(input);

            int result = tal1 / tal2;
            Console.WriteLine($"Resultatet af {tal1}/{tal2} er {result}");

            //Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }
}