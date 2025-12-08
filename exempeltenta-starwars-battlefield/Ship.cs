using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempeltenta_starwars_battlefield
{
    public class Ship
    {
        //använd {get;set} för att skapa properties och inte bara instansvariabler
        public string Name { get; set; }
        public int Energy { get; set; }
        public int MaxAttackPower { get; set; }

        //skapa ett objekt i klassen
        public Ship(string Name, int Energy, int MaxAttackPower)
        {
            Name = name;
            Energy = energy;
            MaxAttackPower = maxattackpower;
        }

    }
}
