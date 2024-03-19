using System;

public class Solution 
{
    public string solution(string s, int n) 
    {
        string answer = "";
            
        foreach (char c in s)
        {
            if (c != ' ')
            {
                int temp = 0;

                temp = c + n;
                if (c < 91)
                {
                    if (temp > 90)
                    {
                        temp = 64 + (temp - 90);
                    }
                }
                else
                {
                    if (temp > 122)
                    {
                        temp = 96 + (temp - 122);
                    }
                }

                answer += Convert.ToChar(temp);
            }
            else
                answer += ' ';
        }
        return answer;
    }

}