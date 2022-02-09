using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZufallsNamen
{
    internal class CSV
    {
        //CSV Dateien nicht integriert
        public static Dictionary<int, string> ReadCSV(string path)
        {
            Dictionary<int, string> vnames = new Dictionary<int, string>();

            string[] lines = File.ReadAllLines("vnamen.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                vnames.Add(i, lines[i].Remove(lines[i].IndexOf(',')));
            }


            return vnames;
        }
    }
}
