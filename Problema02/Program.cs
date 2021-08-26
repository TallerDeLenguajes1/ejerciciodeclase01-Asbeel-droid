using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("\n\nIngresó un número demasiado grande o pequeño\n");
                Console.WriteLine("{0}\n", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió algo inesperado\n");
                Console.WriteLine("{0}\n", ex.Message);
            }

            Console.ReadLine();
        }
    }
}
