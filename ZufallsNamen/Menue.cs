using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZufallsNamen
{
    internal class Menue
    {
        public static void MenueStart()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "Press Enter to generate a random Name\n" +
                    "Press Escape to Exit");
                if (Console.ReadKey().Key == ConsoleKey.Escape) Environment.Exit(0);
                else
                {
                    Console.Clear();
                    Console.WriteLine(Generate.GenerateName(CSV.ReadCSV("vnamen.csv")) + " " +
                        Generate.GenerateName(CSV.ReadCSV("lnamen.csv")));

                }
                Console.ReadKey();
            }
        }
    }
}
