using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        string str = n.ToString();
        char[] chars = str.ToCharArray();
        Array.Sort(chars);
        Array.Reverse(chars);
        answer = Int64.Parse(chars);
        return answer;

    }
}