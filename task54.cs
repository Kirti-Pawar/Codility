using System;

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int c1=0,c2=0;
        

        foreach(int i in A)
        {
            if(i==0)
            {
                c1+=1;
            }
            if(i==1)
            {
                c2+=c1;
                if(c2 >1000000000)
                {
                    return -1;
                }
            }

        }
        return c2;
    }
}