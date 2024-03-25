using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] array, int[,] commands) 
    {
        int[] answer = new int[commands.GetLength(0)];
            
        for(int i  = 0; i < commands.GetLength(0); i++)
        {
            int start = commands[i, 0] - 1;
            int end = commands[i, 1];
            int k = commands[i, 2];

            int[] newArray = array.Skip(start).Take(end - start).ToArray();
            Array.Sort(newArray);
            answer[i] = newArray[k - 1];
        }
        return answer;
    }
}