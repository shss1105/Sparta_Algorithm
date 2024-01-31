public class Solution 
{
    public long solution(int a, int b) 
    {
        long answer = 0;
        long caseA = a-b;
        long caseB = b-a;
        long sum = 0;
        if(a>b)
        {
            for(long i =0 ; i < caseA + 1; i++ )
            {
                sum += a;
                a = a-1;
                answer = sum;
            }
        }
        else if(b>a)
        {
            for(long i =0 ; i < caseB + 1; i++ )
            {
                sum += a;
                a= a+1;
                answer = sum;
            }
        }
        else
        {
            answer = a;
        }
        return answer;
    }
}