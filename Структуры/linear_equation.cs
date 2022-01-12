using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    //Разработать структуру для решения линейного уравнения 0=kx+b.
    //Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
    //Для решения уравнения предусмотреть метод Root.Создать экземпляр разработанной структуры.
    //Осуществить использование экземпляра в программе.


     struct Linear_Equation
    {
 
        public float Ratio1 { get; set; }
        public float Ratio2 { get; set; }
        
        public Linear_Equation(float ratio1, float ratio2)
        {
            Ratio1 = ratio1;
            Ratio2 = ratio2;
        }

        public void Root(float ratio1, float ratio2) //kx + b = 0: k = ratio1, b = ratio2;
        {
            if (ratio1==0)
            {
                Console.WriteLine("Коэффициент 1 не может быть равен 0!");
            }
            else
            {
                float x = (-ratio2 / ratio1);
                Console.Write("X = {0:F2}", x);
            }
                
        }
    }
}
