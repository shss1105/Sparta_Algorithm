using System;

public class Solution 
{
    public int solution(int[] absolutes, bool[] signs) 
    {
        int sum = 0;
        
        for(int i =0; i< absolutes.Length; i++)
        {
            int curAbsolute = absolutes[i];
            bool curSign = signs[i];
            
            if(!curSign)
            {
                curAbsolute = curAbsolute * -1;
            }
            
            sum += curAbsolute;
             
        }
        
        return sum;
    }
}