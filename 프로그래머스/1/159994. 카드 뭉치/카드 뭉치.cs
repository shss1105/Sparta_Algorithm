using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string[] cards1, string[] cards2, string[] goal) 
    {
        string answer = "Yes";

        Queue<string> card1 = new Queue<string>();
        Queue<string> card2 = new Queue<string>();

        foreach(var card in cards1)
        {
            card1.Enqueue(card);
        }

        foreach(var card in cards2)
        {
            card2.Enqueue(card);
        }

        for(int i = 0; i< goal.Length; i++)
        {
            if(card1.Count != 0)
            {
                string check1 = card1.Peek();

                if(check1 == goal[i])
                {
                    card1.Dequeue();
                    continue;
                }
            }

            if(card2.Count != 0)
            {
                string check2 = card2.Peek();

                if(check2 == goal[i])
                {
                        card2.Dequeue();
                    continue;
                }
            }

            answer = "No";
            return answer;
        }
          
        return answer;
    }
}