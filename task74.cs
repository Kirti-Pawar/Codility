class Solution {
    public int solution(int[] H) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
      
        int L = H.Length;
        int stones =0;
        int [] wall = new int [L];
        int wallNum=0;
        
        	for (int i=0; i<L; i++)
        	{
            	while (wallNum>0 && wall[wallNum-1] > H[i]) 
	wallNum -=1;   
            if (wallNum >0 && wall[wallNum -1] == H[i]) continue;
            else 
                {
                    stones +=1;
                    wall[wallNum] = H[i];
                    wallNum +=1;     
                }
        }
        return stones;
    }

}
