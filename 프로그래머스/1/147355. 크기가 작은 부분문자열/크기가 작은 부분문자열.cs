using System;

public class Solution 
{
    public int solution(string t, string p) 
    {
        int answer = 0;

        int tLength = t.Length;
        int pLength = p.Length;
        long pNum = long.Parse(p);

        for (int i = 0; i < tLength - pLength + 1; i++)
        {
            if (long.Parse(t.Substring(i,pLength)) <= pNum)
            {
                answer++;
            }
        }

        return answer;
    }
}