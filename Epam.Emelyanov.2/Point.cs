using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Emelyanov._2
{
    class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"({ x},{ y})";
        }
    }
}
