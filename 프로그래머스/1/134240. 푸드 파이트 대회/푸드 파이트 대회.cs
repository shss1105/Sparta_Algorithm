using System;
using System.Linq;

public class Solution 
{
    public string solution(int[] food) 
    {
    string answer = "";
    int length = 0;

    for (int i = 1; i < food.Length; i++)
    {
        length += (food[i] / 2) * 2;
    }

    length += 1;

    int waterPos = (length / 2);

    for (int i = 1; i < food.Length; i++)
    {
        int halfFood = food[i] / 2;
        for (int j = 0; j < halfFood; j++)
        {
            answer += i.ToString();
        }
    }

    string str = string.Concat(answer.Reverse());
    answer = answer.Insert(waterPos, "0");
    answer += str;

    return answer;
    }
}