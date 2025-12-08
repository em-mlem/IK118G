using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace exempeltenta_starwars_battlefield
{
    public class Battlefield
    {
        public Ship StarDestroyer { get; set; }
        public List<Ship> RebelShips { get; set; }

        public Battlefield()
        {
            //lista
            RebelShips = new List<Ship>();
            //skapa stardestroyer med rätt egenskaper
            StarDestroyer = new Ship("Star Destroyer", 10000, 15);

            //loop for 260 rebelships
            for (int i =0; i<260;i++)
            {
                //Döp skepp till indexnr +1 per loop
                string name = $"X-Wing #{i + 1}";
                //skapa RebelShip med rätt egenskaper
                Ship RebelShip = new Ship(name, 1, 4);
                //lägg till i lista
                RebelShips.Add(RebelShip);
            }
            
        }
        public void RebelAttack()
        {
            //sätt startvärde
            int totalDamage = 0;
            //loopa attack
            foreach (Ship RebelShip in RebelShips)
            {
                int attack = RebelShip.Attack();
                totalDamage += attack;
            }
            //minska energi
            StarDestroyer.Energy -= totalDamage;
            //ingen negativ energi
            if (StarDestroyer.Energy < 0)
            { 
                StarDestroyer.Energy = 0;
            }
        }
        public void ImperialStrike()
        {
            int numberOfHits = StarDestroyer.Attack();
            if (numberOfHits == 0)
            {
                return;
            }
            if (numberOfHits > RebelShips.Count)
            {
                numberOfHits = RebelShips.Count;
            }
            RebelShips.RemoveRange(0, numberOfHits);
        }
        public void StartBattle()
        {
            do
            {
                RebelAttack();
                if (StarDestroyer.Energy <= 0)
                {
                    MessageBox.Show("Rebellerna vann!");
                    break;
                }
                ImperialStrike();
                if (RebelShips.Count == 0)
                {
                    MessageBox.Show("Imperiet vann!");
                    break;
                }
            } while (true);
        }
    }

}
