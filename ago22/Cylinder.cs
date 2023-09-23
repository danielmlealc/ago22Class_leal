using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ago22
{
    internal class Cylinder
    {
        public static void Operation()
        {
            Console.WriteLine("Digite el radio del cilindro:");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la altura del cilindro:");
            double altura = Convert.ToDouble(Console.ReadLine());
            if (radio < 0 || altura < 0)
            {
                Console.WriteLine("El radio y la altura deben ser Naturales.");
            }
            else
            {
                // Calcular el volumen del cilindro
                double volumen = Math.PI * Math.Pow(radio, 2) * altura;
                Console.WriteLine("El volumen del cilindro es: " + volumen);
            }

        }
    }
}
