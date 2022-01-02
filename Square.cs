using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLib
{
    public class Square
    {
        public static double shapeSquare(double radius)    //Площадь круга
        {
            if (radius < 0)         //Проверка на существование круга с таким радиусом
                return 0;
            return Math.PI * radius * radius;
        }

        /*
         * В задании была проверка на прямоугольность треугольника. Не совсем понятно, зачем. Я предположил, что 
         * это на случай, если треугольник прямоугольный, то можно вычислить площадь более простым способом.
        */
        public static double shapeSquare(double a, double b, double c) //Площадь треугольника с проверкой на прямогуольность
        {
            if (!(a + b > c && a + c > b && b + c > a)) //Проверка на сущ-ие треугольника
                return 0;
            threeSwap(ref a, ref b, ref c); //Проверка на прямоугольность. Сортировка сторон (чтобы не перебирать все варианты сочетания сторон, их проще упорядочить)
            if (a * a + b * b == c * c)     
                return triangle90Square(a, b);
            return triangleSquare(a, b, c);
        }

        private static double triangle90Square(double a, double b)  //Площадь прямоугольного треугольника
        {
            return a * b / 2;
        }

        private static double triangleSquare(double a, double b, double c)  //Площадь треугольника по Герону
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private static void threeSwap(ref double a, ref double b, ref double c) //сортировка трёх элементов
        {
            if (a > b) swap(ref a, ref b);
            if (b > c) swap(ref b, ref c);
            if (a > b) swap(ref a, ref b);
        }
        /*
         * Использование ссылок небезопасно, но приемлемо в объёмах поставленной задачи.
         * Если нет, то можно использовать другие виды сортировки, храня величины сторон в массиве
         */
        private static void swap(ref double l, ref double r)    //Обмен
        {
            double tmp = l;
            l = r;
            r = tmp;
        }
        /*
         * Во втором вопросе непонятно - запрос должен быть чисто на SQL, или внедрён в C#?
         * Сделал на SQL, хотя внедрённый запрос выглядел бы логичнее
         */
    }
}
