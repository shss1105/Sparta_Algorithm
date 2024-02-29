using System.Collections.Generic;

public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";
        int length = s.Length;

        List<char> Upper = new List<char>();
        List<char> Lower = new List<char>();

        for (int i = 0; i< length; i++)
        {
            char c = s[i];

            if (char.IsUpper(c))
            {
                Upper.Add(c);
            }
            else if(char.IsLower(c))
            {
                Lower.Add(c);
            }
        }

        Upper.Sort();
        Lower.Sort();
        Upper.Reverse();
        Lower.Reverse();

        Lower.AddRange(Upper);

        answer = string.Join("", Lower);

        return answer;
    }
}