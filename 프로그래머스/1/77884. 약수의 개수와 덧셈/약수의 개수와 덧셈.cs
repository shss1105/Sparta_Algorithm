using System;

public class Solution 
{
    public int solution(int left, int right) 
    {
        int answer = 0;
        int length = (right - left) + 1;

        int count = 0;

        for(int i = 0 ; i < length; i++)
        {
            int num = left + i;

            for (int j = 1 ; j <= num; j++)
            {
                if(num % j == 0)
                {
                    count++;
                }
            }

            if (count % 2 == 0)
            {
                answer += num;
            }
            else
            {
                answer -= num;
            }
            count = 0;
        }
        return answer;
    }
}