using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Day3
    {
        //Part1
        public static void Main(string[] args)
        {
            var x = 277678;
            var y = 1;
            var count = 0;
            while(y<x)
            {
                y = y + 8 * count;
                count++;
            }
            //because we start from 0,0
            var x1 = count-1;
            Console.WriteLine("Val y {0}", y);
            Console.WriteLine("Val count {0}", count);
            var diff = y - x;
            Console.WriteLine("Diff is {0}", diff);
            
            var x2 = x1 - diff;
            var distance = x1 + x2;
            Console.WriteLine("Distance is {0}", distance);
            Console.ReadKey();
        }
    }
}
