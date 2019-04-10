using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Projekt1
{
    class Program

    {
        //Wyszukiwanie liniowe srednia przed instrumentacją
        private static int isPresent(int[] Vector, int Number)
        {

            int lewo = 0, prawo = Vector.Length - 1, srodek = 0;
            while (lewo <= prawo)
            {


                srodek = (lewo + prawo) / 2;
                if (Vector[srodek] == Number)
                    return srodek;
                else if (Vector[srodek] < Number)
                    lewo = srodek + 1;
                else
                    prawo = srodek - 1;
            }

            return -1;

        }
        private static int OpAssignment, OpComparisonLT, OpIncrement, OpComparisonEQ;
        static void Main(string[] args)
        {
            Random rand = new Random();
            Stopwatch stopwatch = new Stopwatch();
            string path = @"d:\n.txt";
            StreamWriter sw = new StreamWriter(path);
            var elapsed = stopwatch.ElapsedMilliseconds;

            int[] tab = new int[2000];
            int minValue = 1;
            int maxValue = 39995435;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(minValue, maxValue);

            }
            Array.Sort(tab);
            long ElapsedTime = 0;
            foreach (var item in tab)
            {
                long StartingTime = Stopwatch.GetTimestamp();
                isPresent(tab, 836312);
                long EndingTime = Stopwatch.GetTimestamp();
                ElapsedTime = EndingTime - StartingTime;
            }
            double ElapsedSeconds = ElapsedTime * (1.0 / tab.Length);
            sw.WriteLine(ElapsedSeconds);
            sw.Close();




            Console.ReadKey();
        }


    }
}