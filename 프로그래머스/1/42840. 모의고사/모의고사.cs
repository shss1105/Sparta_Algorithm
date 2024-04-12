using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] answers) 
    {
        int[] pattern1 = new int[5] { 1, 2, 3, 4, 5 };
        int[] pattern2 = new int[8] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] pattern3 = new int[10] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        int[] score = new int[3] { 0, 0, 0 };
        int max = 0;
        List<int> nList = new List<int>();

        for (int i = 0; i < answers.Length; i++)
        {
            if (pattern1[i % 5] == answers[i]) { score[0]++; }
            if (pattern2[i % 8] == answers[i]) { score[1]++; }
            if (pattern3[i % 10] == answers[i]) { score[2]++; }
        }

        for (int i = 0; i < 3; i++)
        {
            if (max < score[i])
            {
                max = score[i];
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (max == score[i])
            {
                nList.Add(i + 1);
            }
        }

        return nList.ToArray();
    }
}