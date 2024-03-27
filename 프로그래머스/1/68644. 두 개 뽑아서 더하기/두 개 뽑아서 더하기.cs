using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] numbers) 
    {
        List<int> answer = new List<int>();
            
        for (int i = 0; i < numbers.Length-1; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                int temp = numbers[i] + numbers[j];
                
                //  item이 존재하면 Contain 함수는 True를 반환하고 그렇지 않으면 False를 반환
                if (answer.Contains(temp) == false)
                {
                    answer.Add(temp);
                }
            }
        }
           	
        answer.Sort();
           
        return answer.ToArray();
    }
}