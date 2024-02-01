public class Solution 
{
    public long solution(long num) 
    {
        long answer = 0;
        long count = 0;

        if (num == 1)
        {
            return count;
        }

        while (num > 1)
        {
            if(count < 500)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    count++;
                }
                else if (num % 2 == 1)
                {
                    num = (num * 3) + 1;
                    count++;
                }
            }
            else
            {
                count = -1;
                num =1;
            }

        }
        answer = count;
        return answer;
    }
}