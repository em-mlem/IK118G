using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempeltenta_squidgame
{
    public class Game
    {
        private List<Contestant> _contestants;

        public Game()
        {
            _contestants = new List<Contestant>();
            InitializeContestants(456);
        }

        private void InitializeContestants(int total)
        {
            // Skapa total antal tävlande
            for (int i = 1; i <= total; i++)
            {
                _contestants.Add(new Contestant(i));
            }
        }
        public bool GlassBridge(string route)
        {
            int[] left = new int[] { 0, 0, 1, 0, 1, 1, 0, 0, 1, 0 };
            int[] right = new int[] { 1, 1, 0, 1, 0, 0, 1, 1, 0, 1 };

            // Säkerhetscheck: vägens längd måste matcha brons längd
            if (route.Length != left.Length)
            {
                return false;
            }

            // Gå steg för steg över bron
            for (int i = 0; i < route.Length; i++)
            {
                char step = route[i];

                if (step == 'L')
                {
                    if (left[i] == 0)
                    {
                        return false; // svag ruta → faller
                    }
                }
                else if (step == 'R')
                {
                    if (right[i] == 0)
                    {
                        return false; // svag ruta → faller
                    }
                }
                else
                {
                    // Ogiltig symbol, t.ex. något annat än L/R
                    return false;
                }
            }

            // Klarade alla steg utan att falla
            return true;
        }
    }
}
