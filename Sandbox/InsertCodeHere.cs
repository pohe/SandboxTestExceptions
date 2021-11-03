using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            try
            {
                string input = "";
                Console.WriteLine("Indtast tal1:");
                input = Console.ReadLine();
                int tal1 = int.Parse(input);

                Console.WriteLine("Indtast tal2:");
                input = Console.ReadLine();
                int tal2 = int.Parse(input);

                int result = tal1 / tal2;
                Console.WriteLine($"Resultatet af {tal1}/{tal2} er {result}");
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Format exception " + fex.Message);
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Hov du forsøgte at dividere med 0, det må du ikke!");
            }
            catch (OverflowException oex)
            {
                Console.WriteLine("Tallet er for stort!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Generel exception " + e.Message);
                //throw;
            }
            finally  //Blver udført under alle omstændigheder 
            {
                Console.WriteLine("Denne del bliver altid udført!");
            }
           

            Console.WriteLine("Slut på test af exceptions");

            // The LAST line of code should be ABOVE this line
        }
    }
}