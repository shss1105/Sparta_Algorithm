using System;

public class Solution 
{
    public int solution(int[] numbers) 
    {
        int answer = -1;
        int total = 45;
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
                
        }

        answer = total - sum;
        return answer;
    }
    
}