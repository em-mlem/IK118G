using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempeltenta_bil_blackjack
{
    public class CarRegister
    {
        public List<Car> Cars { get; set; }

        public CarRegister()
        {
            Cars = new();
        }
    }
}
