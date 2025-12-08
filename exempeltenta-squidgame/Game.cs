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
    }
}
