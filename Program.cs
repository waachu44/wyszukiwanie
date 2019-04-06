using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Projekt1
{
    class Program
    {
        //Wyszukiwanie liniowe przed instrumentacją
        private static bool isPresent(int[] Vector, int Number)
        {

            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] == Number)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            Stopwatch stopwatch = new Stopwatch();
            string path = @"d:\x.txt";
            StreamWriter sw = new StreamWriter(path);
            int[] tab = new int[2000];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next();
                Array.Sort(tab);
                stopwatch.Start();
                isPresent(tab, 202313);
                stopwatch.Stop();
                stopwatch.Reset();
                sw.WriteLine((i + 1) + " " + tab[i] + " " + stopwatch.ElapsedMilliseconds);

            }
            sw.Close();

            Console.ReadKey();
        }


    }
}
