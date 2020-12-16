using System;
// you can also use other imports, for example:
 using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        Stack<int> fish = new Stack<int>();  
        for(int i = 0; i < A.Length; i++)
        {
            if(fish.Count==0)
            {
                    fish.Push(i);
            }
            else
            {
                    while(fish.Count!=0 && B[i] - B[fish.Peek()] == -1  && A[fish.Peek()] < A[i])  
                    { 
                        fish.Pop(); 
                    }

                    if (fish.Count !=0) 
                    { 
                        if(B[i] - B[fish.Peek()] != -1) 
                            fish.Push(i); 
                    }

                    else 
                    { 
                        fish.Push(i); 
                    }
            }
        }
    return fish.Count;
    }
}