using System;

public class Solution 
{
    public int[] solution(int k, int[] score) 
    {
        int[] answer = new int[score.Length];
        int[] board = new int[k];

        for (int i = 0; i < board.Length; i++)
            board[i] = -1;

        for (int i = 0; i < score.Length; i++)
        {
            int target = score[i];
            int min = 2001;
            for (int j = 0; j < board.Length; j++)
            {
                if (board[j] < target)
                {
                    int temp = board[j];
                    board[j] = target;
                    target = temp;
                }

                if (board[j] > -1 && min > board[j])
                    min = board[j];
            }
            answer[i] = min;
        }
        return answer;
    }
}