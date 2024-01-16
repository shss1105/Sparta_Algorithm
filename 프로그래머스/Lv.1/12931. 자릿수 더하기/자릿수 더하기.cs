using System;

public class Solution 
{
    public int solution(int n) 
    {
        string number = n.ToString();

        char[] list = number.ToCharArray();

        int answer = 0;

        for (int i = 0; i < number.Length; i++)
        {
            answer += int.Parse(number[i].ToString());
        }
        return answer;
    }
}