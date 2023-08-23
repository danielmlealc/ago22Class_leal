using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ago22
{
    internal class Average
    {
        /// <summary>
        /// 
        /// </summary>
        public static void ejecutarEjercicio()
        {
            Console.WriteLine("Ingrese el primer número: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            double promedio = Calculate(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine($"El promedio entre {firstNumber}, {secondNumber} y {thirdNumber} es: {promedio}");
        }

        static double Calculate(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3) / 3.0;
        }
    }
}
