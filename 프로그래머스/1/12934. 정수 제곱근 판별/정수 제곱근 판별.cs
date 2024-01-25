public class Solution 
{
    public long solution(long n) 
    {
        long answer = 0;
        long num;
            
        for (long i = 1; i < n+1; i++)
        {
            if (n  == i * i)
            {
                answer = (i + 1) * (i + 1);
                break;
            }
            else if(n / i != i)
            {
                answer = -1;
            }
        }
        return answer;
    }
}