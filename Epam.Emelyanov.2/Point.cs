using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Emelyanov._2
{
    class Point
    {
        public int X { get ; set ; }
        public int Y { get ; set ; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return $"({ X},{ Y})";
        }
    }
}
