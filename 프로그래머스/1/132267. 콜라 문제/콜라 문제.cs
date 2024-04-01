using System;

public class Solution 
{
    public int solution(int a, int b, int n) 
    {
        int answer = 0;
        int gain = 0;
        int cokeNum = n / a;
            
        while(cokeNum > 0)
        {
            cokeNum = (n / a) * b;
            int giveBottle = (n / a) * a;
            int empty = n - giveBottle + cokeNum;
            n = empty;
            gain += cokeNum;
        }

        answer = gain;
        return answer;
    }
}