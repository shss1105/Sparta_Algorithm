using System;
public class Solution 
{
    public int[] solution(int[] arr, int divisor) 
    {
        int count = 0;
        for (int t = 0; t<arr.Length; t++)
        {
            if (arr[t] % divisor == 0)
            {
                count++;
            }
        }
        int[] answer = new int[count];

        for(int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; arr[i] % divisor == 0; j++)
            {
                answer[j] = arr[i];
                break;
            }
            Array.Sort(answer);
        }

        if (count == 0)
        {
            answer = new int[count + 1];
            answer[count] = -1;
        }
        return answer;
        }
    }