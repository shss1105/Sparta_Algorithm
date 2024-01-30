public class Solution 
{
    public bool solution(int x) 
    {
        bool answer = false;
        int numX = x;
        int sum = 0;
        
        while(x>0)
        {
            sum += x%10;
            x = x/10;
        }
        
        if(numX%sum == 0)
        {
            answer = true;
        }
        return answer;
    }
}