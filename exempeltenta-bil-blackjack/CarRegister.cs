using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempeltenta_bil_blackjack
{
    public class CarRegister
    {
        public bool HasCorrectFormat(string reg)
        {
            if (reg.Length != 7)
                return false;
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(reg[i]))
                    return false;

                char c = char.ToUpper(reg[i]);
                if (c == 'O' || c == 'I' || c == 'Q')
                    return false;
            }
            if (reg[3] != ' ')
                return false;

            if (!char.IsDigit(reg[4]) || !char.IsDigit(reg[5]) || !char.IsDigit(reg[6]))
                return false;

            return true;
        }
        public List<Car> Cars { get; set; }

        public CarRegister()
        {
            Cars = new List<Car>();
        }

        public bool AddCar(Car c)
        {
            if (!HasCorrectFormat(c.LicencePlate))
            {
                return false;
            }
            Cars.Add(c);
            return true;
        }
    }
}
