public class Solution 
{
    public bool solution(int x) 
    {
        bool answer = false;
        string str = x.ToString();
        int sum = 0;
        int numX = x;
            
        for (int i = 0; i < str.Length; i++)
        {
            sum += x % 10;
            x /= 10;
        }

        if(numX % sum == 0)
        {
            answer = true;
        }
            
        return answer;
    }
}
