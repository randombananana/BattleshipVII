using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleshipv2
{
    class Program
    {
        private static Random _random = new Random();

        static void Main(string[] args)
        {
            try
            {
                while (true)
                {

                    Map map = new Map(10, 10);

                    MapLocation point = new MapLocation(5, 5, map);

                    Ship ship1 = new Ship(5, 5, map);


                    Console.WriteLine("Player 1 enter positon x of your ship");
                    int pc1x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Player 1 enter positon y of your ship");
                    int pc1y = Convert.ToInt32(Console.ReadLine());

                    Ship shipPc1 = new Ship(pc1x, pc1y, map);

                    Console.WriteLine("Please enter in the coordinates you would like to hit");
                    double entry = Convert.ToDouble(Console.ReadLine());

                    if (shipPc1.ShipLocation == entry)
                    {
                        Console.WriteLine("WoW!!!");
                    }
                    else
                    {
                        Console.WriteLine("You didn't hit the ship, try again.");
                    }
                }
            }
            catch
            {
                
            }
        }

    }
}
