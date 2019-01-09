using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int[] solution(int N, int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] counters = new int[N];
        int lastMax = 0;
        int currentMax = 0;
        foreach(var item in A)
        {
            if(item > N)
            {
                //Then this is a max command. Set last max to currentMax
                lastMax = currentMax;
            }
            else
            {
                counters[item - 1] = Math.Max(counters[item - 1], lastMax);
                counters[item - 1]++;
                currentMax = Math.Max(currentMax, counters[item - 1]);
            }
        }

        //Fix for any counters that never had their max set
        for(int i = 0; i < counters.Length; i++)
        {
            counters[i] = Math.Max(counters[i], lastMax);
        }
        return counters;
    }
}