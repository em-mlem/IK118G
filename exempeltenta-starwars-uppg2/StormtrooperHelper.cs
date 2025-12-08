using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace exempeltenta_starwars_uppg2
{
    public class StormtrooperHelper
    {
        public List<string> codes = new List<string>()
        {
            "SD-4050", "UA-9652", "NN-1844", "UF-7585", "CJ-5715","TV-7320", "AW-2115", "HO-8661", "MH-6752", "OD-4211","US-3851", "BY-7386", "XB-2895", "UH-9835", "IY-5048","UP-5881", "XE-7904", "JT-9503", "CK-6154", "MH-7349","IX-4566", "SY-5452", "KA-4631", "UV-8280", "ME-6167","DY-6296", "KR-7447", "CP-9734", "OL-9527", "JY-5962","DL-7691", "MM-4271", "OP-9897", "XK-6177", "DD-4022","XV-6450", "JX-5178", "YC-6554", "YF-3861", "KD-5645","NB-1435", "VQ-4486", "BY-7012", "FN-4039", "OL-3378","DX-5503", "PP-6387", "IA-1179", "CD-4362", "DM-3566","BD-5275", "LK-4363", "NH-5119", "XW-8981", "XE-4610","DJ-6757", "IV-3409", "UT-5644", "WF-1376", "AT-5724","AX-5236", "JE-4570", "VD-1345", "WP-7037", "BR-7645","RK-8569", "PY-7913", "ST-7010", "AF-4320", "XN-2824","IM-5696", "XX-9583", "KN-9952", "AG-3313", "PL-3104","OT-1941", "TF-8207", "FK-8239", "SG-2490", "UJ-9434","AW-6149", "UN-2041", "DC-7763", "TH-8644", "VP-7267","MD-3799", "KK-5075", "GE-4142", "KD-1797", "RE-6894","TP-2703", "BY-4244", "RT-9132", "CL-6986", "IY-9190","XI-8159", "CG-2324", "VJ-9502", "MT-7498", "FK-4846"
        };
        public bool AddStormtrooperId(string newId)
        {
            string newIdLower = newId.ToLower();
            string[] parts = newIdLower.Split('-');

            string newLetters = parts[0];
            string newNumbers = parts[1];
            //loopa alla koder och jämför
            foreach (string code in codes)
            {
                string[] existingParts = code.ToLower().Split('-');
                string existingNumbers = existingParts[1];
                if (existingNumbers == newNumbers)
                {
                    //ID finns redan, felmeddelande
                    MessageBox.Show("Koden används redan. Ange unik kod.");
                    return false;
                }
            }
            //ID är unikt, returnera true och lägg till
            codes.Add(newId);
            MessageBox.Show("Stormtrooper-ID tillagt: " + newId, "Klart!");
            return true;
        }
    }
}
