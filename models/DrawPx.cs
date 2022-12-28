using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class DrawPx : IDraw
    {
        public int drawM(int x, int y,int res, int Width, int Height, double wx, double wy, double zoom)
        {

            double a = (double)((x + (wx / res / zoom)) - ((Width / res / 2d))) / (double)(Width / res / zoom / 1.777f);
            double b = (double)((y + (wy / res / zoom)) - ((Height / res / 2d))) / (double)(Height / res / zoom);

            Numbers c = new Numbers(a, b); // указание координаты
            Numbers z = new Numbers(0, 0); // указание отображения -1.7433419053321, 0.0000907687489

            int it = 0;

            do
            {
                it++;
                z.Sqr();
                z.Add(c);
                if (z.Magn() > 2.0d)
                {
                    break;
                }
            } while (it < 100); // выполняется процесс итерация
            return it;
        }

        public int drawFractalM(int x, int y, int Width, int Height)
        {
            double newRe, newIm;
            //вычисляется реальная и мнимая части числа z
            //на основе расположения пикселей,масштабирования и значения позиции
            newRe = (double)(x - Width / 2d) / (double)(Width / 4);
            newIm = (double)(y - Height / 2d) / (double)(Height / 2.75);
            Numbers c = new Numbers(newRe, newIm); // указание координаты
            Numbers z = new Numbers(0, 0); // указание отображения -1.7433419053321, 0.0000907687489

            int it = 0;

            do
            {
                it++;
                z.Sqr();
                z.Add(c);
                if (z.Magn() > 2.0d)
                {
                    break;
                }
            } while (it < 100); // выполняется процесс итерация

            return it;
            //определяем цвета
        }

        public int drawJ(int x, int y, int res, int Width, int Height, double wx, double wy, double zoom, double pointX, double pointY)
        {
            // масштабируем расположение позиций
            double a = (double)((x + (wx / res / zoom)) - ((Width / 2d) / res)) / (double)(Width / zoom / res / 1.777f);
            double b = (double)((y + (wy / res / zoom)) - ((Height / 2d) / res)) / (double)(Height / zoom / res);
            Numbers c = new Numbers(pointX, pointY);  //0.28,0.0113 ; -1 0
            Numbers z = new Numbers(a, b);


            int it = 0;

            do
            {
                it++;
                z.Sqr();
                z.Add(c);
                if (z.Magn() > 2.0d)
                {
                    break;
                }
            } while (it < 100);

            return it;
        }
    }
}
