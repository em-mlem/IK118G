using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempeltenta_starwars_battlefield
{
    public class Battlefield
    {
        public Ship StarDestroyer { get; set; }
        public List<Ship> RebelShips { get; set; }

        public Battlefield(Ship ship)
        {
            StarDestroyer = ship;
            RebelShips = new List<Ship>();
        }
    }
}
