using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Решить линейное уравнение kx+b = 0");
                Console.WriteLine("Введите коэффициенты уравнения:");
                Console.Write("Введите 1-й коэффициент: ");
                int ratio1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите 2-й коэффициент: ");
                int ratio2 = Convert.ToInt32(Console.ReadLine());
                Linear_Equation linear = new Linear_Equation(ratio1, ratio2);
                linear.Root(ratio1, ratio2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
