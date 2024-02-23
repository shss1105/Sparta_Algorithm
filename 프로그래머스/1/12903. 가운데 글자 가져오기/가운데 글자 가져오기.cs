using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public string solution(string s) 
    {
        string answer = "";

        List<string> chars = new List<string>();
        chars.AddRange(s.Select(c => c.ToString()));


        int length = s.Length;

        if(length % 2 != 0)
        {
            int temp1 = length / 2;
            int temp2 = length % 2;
            int target = (temp1 + temp2) - 1;

            answer = chars[target];
        }
        else
        {
            int target = length / 2;

            answer = chars[target - 1] + chars[target];
        }
        return answer;
    }
}