using System;

public class Solution 
{
    public int solution(int[,] sizes) 
    {
        int answer = 0;

        int maxWidth = 0;
        int maxHeight = 0;
    
        for (int i = 0; i < sizes.GetLength(0); i++)  // 행의 개수
        {
            int width = Math.Max(sizes[i, 0], sizes[i, 1]);
            int height = Math.Min(sizes[i, 0], sizes[i, 1]);

            if (maxWidth < width)
            {
                maxWidth = width;
            }

            if (maxHeight < height)
            {
                maxHeight = height;
            }
            answer = maxWidth * maxHeight;
            
        }

        return answer;
    }
}