using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleshipv2
{
    class Ship
    {
        public double ShipLocation { get; set; }

        public int ShipX { get; set; }
        public int ShipY { get; set; }

        public Ship(int x, int y, Map map)
        {
            ShipX = x;
            ShipY = y;

            double a = Convert.ToDouble(string.Format("{0}{1}", ShipX, ShipY));
            ShipLocation = a;
        }
    }
}
