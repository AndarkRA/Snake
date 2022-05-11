using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Figure
    {
        public Snake(Point tail, int leght, Direction direction)
        {
            plist = new List<Point>();
            for (int i = 0; i < leght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }

        }
    }
}
