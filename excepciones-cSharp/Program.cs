using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones_cSharp
{
    // Daniel Gutierrez Agaton+
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Escribe un numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escribe otro numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                
            }

            catch (FormatException e)
            {
                Console.Write(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
            }
            Console.ReadLine();

        }
    }
}
