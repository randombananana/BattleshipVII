using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleshipv2
{
    class MapLocation
    {
        public readonly int X;
        public readonly int Y;
        public readonly double A;

        public MapLocation(int x, int y, Map map)
        {
            X = x;
            Y = y;

            double a = Convert.ToDouble(string.Format("{0}{1}", X, Y));
            A = a;


            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map.");
            }
        }

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));

        }

        public int DistanceTo(MapLocation point)
        {
            return DistanceTo(point.X, point.Y);
        }
}
}
