using System;

public class Solution 
{
    public int solution(int k, int m, int[] score) 
    {
        int answer = 0;

        Array.Sort(score);
        Array.Reverse(score);

        for (int i = 0; i < score.Length / m; i ++)
        {
            int start = i * m;
            int last = start + m - 1;

            answer += score[last] * m; 
      
        }
        
        return answer;
    }
}