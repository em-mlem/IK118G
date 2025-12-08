using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exempeltenta_starwars
{
    public static class LightSaberHelper
    {
        // force = 1–100, isJedi = true (Jedi), false (Sith)
        public static string GetColor(int force, bool isJedi)
        {
            // säkerställ att värdet ligger mellan 1 och 100
            if (force < 1) force = 1;
            if (force > 100) force = 100;

            if (isJedi)
            {
                // Jedi-tabellen
                // 1-20 Blå
                // 21-40 Gul
                // 41-60 Grön
                // 61-80 Orange
                // 81-100 Lila
                if (force <= 20) return "Blå";
                if (force <= 40) return "Gul";
                if (force <= 60) return "Grön";
                if (force <= 80) return "Orange";
                return "Lila";
            }
            else
            {
                // Sith-tabellen
                // 1-50 Blå
                // 51-100 Röd
                if (force <= 50) return "Blå";
                return "Röd";
            }
        }
    }
}
