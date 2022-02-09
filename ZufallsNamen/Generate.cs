using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZufallsNamen
{
    internal class Generate
    {
        public static string GenerateName(Dictionary <int, string> names)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);


            return names[rnd.Next(0,names.Count)];
        }
    }
}
