using System;

public class Solution {
    public int solution(int age) 
    {
        int answer = 0;
        int currentYear = 2022;
        
        if(age > 0 && age <= 120)
        {
            answer = currentYear - age + 1;
        }
        
        return answer;
    }
}