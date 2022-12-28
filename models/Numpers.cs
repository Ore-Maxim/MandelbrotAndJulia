using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Numbers : INumbers
    { // класс для обработки комплексных чисел
        public double a;
        public double b;

        public Numbers(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Sqr()
        {
            double tmp = (a * a) - (b * b); // вычисление действительной части
            b = 2.0d * a * b; // вычисление мнимой части
            a = tmp;
        }

        public double Magn()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        public void Add(Numbers c)
        {
            a += c.a;
            b += c.b;
        }

    }
}
