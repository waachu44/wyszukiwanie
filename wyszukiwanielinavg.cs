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
        //Wyszukiwanie liniowe srednia przed instrumentacją
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
            //Stopwatch stopwatch = new Stopwatch();
            string path = @"d:\z.txt";
            StreamWriter sw = new StreamWriter(path);
            int[] tab = new int[2000];
            int minValue = 1;
            int maxValue = 39995435;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(minValue, maxValue);
         
            }
            Array.Sort(tab);
            foreach (var item in tab)
            {
                long ElapsedTime =0;
                for (int i = 0; i <tab.Length; i++)
                {
                    long StartingTime = Stopwatch.GetTimestamp();
                    isPresent(tab, 86312);
                    long EndingTime = Stopwatch.GetTimestamp();
                    ElapsedTime = EndingTime - StartingTime;
                }
                
                double ElapsedSeconds = ElapsedTime * (1.0 / tab.Length);
                sw.WriteLine(ElapsedSeconds);
            }
            
            sw.Close();

            Console.ReadKey();
        }


    }
}

