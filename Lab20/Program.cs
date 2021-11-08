using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double r);//Объявляем класс delegate 
        static void Main(string[] args)
        {
            MyDelegate myDelegate = CircleLength;//Создаем экземпляр класса и одновременно "присваиваем" ему ссылку на метод
            Console.WriteLine(myDelegate(8.2));

            myDelegate = CircleArea;//"Присваиваем" следующй метод
            Console.WriteLine(myDelegate(8.2));

            myDelegate = SphereVolume;//Вызываем метод нахождения объема сферы.
            Console.WriteLine(myDelegate(8.2));
            Console.ReadKey();
        }
        static double CircleLength(double r)
        {
            double d = 2 * Math.PI * r;
            return d;
        }
        static double CircleArea(double r)
        {
            double s = Math.PI * r * r;
            return s;
        }
        static double SphereVolume(double r)
        {
            double v = (4 / 3) * Math.PI * r * r * r;
            return v;
        }
    }
}
