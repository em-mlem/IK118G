using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempeltenta_starwars_battlefield
{
    public class Ship
    {
        //skapa random metod
        private static readonly Random random = new Random();
        //använd {get;set} för att skapa properties och inte bara instansvariabler
        public string Name { get; set; }
        public int Energy { get; set; }
        //ta bort set för att skapa skrivskyddat
        public int MaxAttackPower { get; }

        //skapa ett objekt i klassen
        public Ship(string name, int energy, int maxattackpower)
        {
            Name = name;
            Energy = energy;
            MaxAttackPower = maxattackpower;
        }

        //kalla på random metod i int attack
        public int Attack()
        {
            return random.Next(0, MaxAttackPower + 1);
        }

    }
}
