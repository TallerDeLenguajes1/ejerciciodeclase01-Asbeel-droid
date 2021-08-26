using System;


namespace AdivinarElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num, numRandom, intentos;
            Boolean encontrado = false;

            numRandom = random.Next(1, 101);
            intentos = 0;
            Console.Write("Adivina el numero entre 0 y 100: ");
            try
            {
                do
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("\nIngreso invalido");
                        Console.Write("Ingrese un numero entre 0 y 100: ");
                    }
                    else
                    {
                        if (num < 0 || num > 100)
                        {
                            Console.WriteLine("\nEl numero ingresado esta fuera del rango");
                            Console.Write("Ingrese un numero entre 0 y 100: ");
                        }
                        else
                        {
                            if (num == numRandom)
                            {
                                encontrado = true;
                            }
                            else
                            {
                                if (num < numRandom)
                                {
                                    Console.WriteLine("\nEl número " + num + " es incorrecto, busca un número más grande");
                                    Console.Write("Ingrese un número entre 0 y 100: ");
                                }
                                else
                                {
                                    Console.WriteLine("\nEl número " + num + " es incorrecto, busca un número más pequeño");
                                    Console.Write("Ingrese un número entre 0 y 100: ");
                                }

                            }
                        }
                    }
                    intentos++;
                } while (encontrado == false);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("\n\nNumero demasiado grande o pequeño, el programa murió x.x\n");
                Console.WriteLine("{0}\n", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio algo inesperado, el programa murió x.x\n");
                Console.WriteLine("{0}\n", ex.Message);
            }

            if (encontrado == true)
            {
                Console.WriteLine("\n\nFelicidades adivinaste el numero!!\n");
                Console.WriteLine("\nGanaste este juego en " + intentos + " intentos\n");
                Console.ReadLine();
            }
            
        }
    }
}
