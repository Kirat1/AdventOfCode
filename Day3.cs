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
            var x = 1024;
            var y = 1;
            var count = 0;
            while (y < x)
            {
                y = y + 8 * count;
                if(y<x)
                    count++;
            }
            //because we start from 0,0
            var x1 = count;
            var diff = y - x;
            if (diff > count)
            {
                diff = diff/2 -1;
            }
            var x2 = x1 - diff;
            if (x2 < 0)
                x2 *= -1;
            var distance = x1 + x2;
            Console.WriteLine("Distance is {0}", distance);
            Console.ReadKey();

        }
    }
}
