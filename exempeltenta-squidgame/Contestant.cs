using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempeltenta_squidgame
{
    public class Contestant
    {
        public int Number { get; }

        public Contestant(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Deltagarens nummer måste vara större än 0.");
            }

            Number = number;
        }
    }
}
