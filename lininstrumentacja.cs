﻿using System;
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
        private static bool isPresent(int[] Vector, int Number)
        {
            string path = @"d:\c.txt";
            StreamWriter sw = new StreamWriter(path);
            double ElapsedTime = 0;
            OpIncrement = 1;
            for (int i = 0; i < Vector.Length; i++, OpIncrement++)
            {

                long StartingTime = Stopwatch.GetTimestamp();
                if (Vector[i] == Number) return true;
                long EndingTime = Stopwatch.GetTimestamp();
                ElapsedTime = EndingTime - StartingTime;
                

                //Thread.Sleep(100);
                sw.WriteLine(i+" "+Vector[i]+" "+OpIncrement+" "+ElapsedTime);
                
            }
            sw.Close();
            return false;

        }
        private static int OpAssignment, OpComparisonLT, OpIncrement, OpComparisonEQ;
        static void Main(string[] args)
        {
            Random rand = new Random();
            Stopwatch stopwatch = new Stopwatch();

            var elapsed = stopwatch.ElapsedMilliseconds;
            
            int[] tab = new int[2000];
            int minValue = 1;
            int maxValue = 39995435;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(minValue, maxValue);

            }
            Array.Sort(tab);
            isPresent(tab, 86312);





            Console.ReadKey();
        }


    }
}
