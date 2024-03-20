using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(string s) 
    {
        int answer = 0;

        List<string> strings = new List<string>() { 
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        List<string> numbers = new List<string>() { 
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        for (int i = 0; i< strings.Count; i++)
        {
            s = s.Replace(strings[i], numbers[i]);
        }

        answer = int.Parse(s);
        return answer;
    }
}