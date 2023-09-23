using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ago22
{
    internal class Area
    {
        public static void Operation()
        {
            Console.WriteLine("Ingrese la base del rectangulo:");
            double baseR = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo:");
            double altura = Convert.ToDouble(Console.ReadLine());
            double area = baseR * altura;
            double perimetro = 2 * (baseR + altura);
            Console.WriteLine("Area del rectangulo: " + area);
            Console.WriteLine("Perimetro del rectangulo: " + perimetro);
        }
    }
}
