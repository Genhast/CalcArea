using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace CalcArea
{
    public class CalcAreasp
    {
        public dynamic CalcCircleArea(double r) // Вычисление площади круга по радиусу
        {
            double S = Math.PI * r;
            return (S);
        }
        public dynamic CalcTriangeAreaIN(double a, double b, double c) // Вычисление площади треугольника по трём сторонам
        {
            double S;

            if (((a + b) > c) && ((a + c) > b) && ((c + b) > a))
            {
                S = (a * b * c) / 2;
                return S;
            }
            else
            {
                return ("Это не треугольник");
            }
        }
        public dynamic TriangleRIghtCheck(double a, double b, double c) // Проверка, является ли треугольник прямоугольным
        {
            string result;

            if (((a + b) > c) && ((a + c) > b) && ((c + b) > a))
            {
                if ((Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2)) || (Math.Pow(a,2) + Math.Pow(c,2) == Math.Pow(b,2)) || (Math.Pow(c,2) + Math.Pow(b,2) == Math.Pow(a,2)))
                {
                    result = "Это прямоугольный треугольник";
                }
                else
                {
                    result = "Это не прямоугольный треугольник";
                }
                return result;
            }
            else
            {
                return ("Это не треугольник");
            }
        }
    }
 }
