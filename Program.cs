using System;

namespace ConsoleApp3Ejercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            static double calcularsuperficie (double ladoa, double ladob)
            {
                double superficie;
                
                if (ladoa == ladob)
                {
                    superficie = Math.Pow(ladoa, 2);
                    return superficie;
                    
                }
                else
                {
                    superficie = ladoa * ladob;
                    return superficie;
                        
                    
                }
              
            }
            static double calcularperimetro(double ladoa, double ladob)
            {
                double perimetro;

                if (ladoa == ladob)
                {
                    perimetro = ladoa * 4;
                    return perimetro;
                }
                else
                { 
                    perimetro = 2 * ladoa + 2 * ladob;
                    return perimetro;

                }
            }
            
                

            double ladoA, ladoB;

            Console.WriteLine("ingrese el valor del lado A");
            ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor del lado b");
            ladoB = double.Parse(Console.ReadLine());

            if (ladoA == ladoB)
            {
                Console.WriteLine($"Los valores ingresados equivalen a un cuadrado");
                Console.WriteLine($"La Superficie del cuadrado es {calcularsuperficie(ladoA, ladoA)}");
                Console.WriteLine($"El perimetro del cuadrado es {calcularperimetro(ladoA, ladoA)}");
            }
            else
            {
                Console.WriteLine($"Los valores ingresados equivalen a un Rectangulo");
                Console.WriteLine($"La Superficie del Rectangulo es {calcularsuperficie(ladoA, ladoB)}");
                Console.WriteLine($"El perimetro del Rectangulo es {calcularperimetro (ladoA, ladoB)}");
            }
            Console.ReadLine();
        }
    }
    
}
