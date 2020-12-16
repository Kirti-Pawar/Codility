using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
public int solution(string S) 
{
        // write your code in C# 6.0 with .NET 4.5 (Mono)
	Stack<char> s = new Stack<char>();
        	if(S.Length==0) 
        	{
            		return 1;
        	}
        
           	foreach(char c in S)
	{
            	if(c=='(')
	{
                	s.Push(c);
            	}
            	else
	{
                	if(s.Count==0) return 0;
                	if(c==')')	
		{
                    		if(s.Peek()=='(') s.Pop();
                    		else return 0;
                	}
	}       
	}
        

        if(s.Count==0) 
            return 1;

        return 0;
    }
}