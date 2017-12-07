using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Day6
    {
        //part 1 and 2
        //static int[][] list = new int[9999999][];
        //public static void Main(string[] args)
        //{
        //    int count = 0;
        //    int[] hold = { 4, 10, 4, 1, 8, 4, 9, 14, 5, 1, 14, 15, 0, 15, 3, 5 };
        //    int[] rearrange = { 4, 10, 4, 1, 8, 4, 9, 14, 5, 1, 14, 15, 0, 15, 3, 5 };
        //    int maxIndex = Array.IndexOf(rearrange, rearrange.Max());
        //    int[] standby = shuffle(rearrange, maxIndex);
        //    int[] input = shuffle(hold, maxIndex);
        //    list[count] = input;
        //    count++;
        //    do
        //    {
                
        //        maxIndex = Array.IndexOf(input,input.Max());
        //        standby = shuffle(standby, maxIndex);
        //        input = new int[16];
        //        Array.Copy(standby,input,16);
        //        list[count] = input;
        //        count++;                
        //    }while (!compare(input, list,count));
        //    Console.WriteLine("The count is {0}", count);
        //    Console.WriteLine("Difference between iterations is {0}", (count - findNumber(input)));
        //    Console.ReadKey();
        //}
        //internal static int findNumber(int[] input)
        //{
        //    var index = 0;
        //    for(var i = 0;i<list.Length;i++)
        //    {
        //        if(compare(input,list[
        //            i]))
        //        {
        //            index = i;
        //            for (var x = 0; x < input.Length; x++)
        //            {
        //                Console.Write(list[4802][x] + ", ");
        //            }
        //            return index;
        //        }
        //    }
            
        //    return index;
        //}
        //internal static bool compare(int[] input,int[] inputt)
        //{
        //    for(var i =0;i<input.Length;i++)
        //    {
        //        if (input[i] != inputt[i])
        //            return false;
                  
        //    }
        //    return true;
        //}
        //internal static bool compare(int[] input,int[][] list,int count)
        //{
        //    var num = 0 ;
        //    for (var i = 0;i<count-1;i++)
        //    {
        //         num = 0;
        //        for (var j = 0; j < input.Length; j++)
        //        {
        //            if (input[j] == list[i][j])
        //            {
        //                num++;
        //                if(num == 16)
        //                {
        //                    return true;
        //                }
        //            }
        //        }
        //    }
        //        return false;
        //}
        //internal static int[] shuffle(int[] rearrange, int maxIndex)
        //{
        //    int maxBlockes = rearrange[maxIndex];
        //    rearrange[maxIndex] = 0;
        //    for(var i = 0;i<maxBlockes;i++)
        //    {
        //        maxIndex++;
        //        if (maxIndex == rearrange.Length)
        //            maxIndex = 0;
        //        rearrange[maxIndex]++;
        //    }
        //    return rearrange;
        //}
        
    }
}
