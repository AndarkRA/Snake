using System;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24,78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();



            // отрисовка точек
            Point p = new Point(4, 5, '*');
            p.Draw();


            Console.ReadLine();
        }

    }
}
