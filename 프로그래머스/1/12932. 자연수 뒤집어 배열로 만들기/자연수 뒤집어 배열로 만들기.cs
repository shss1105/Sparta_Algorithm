public class Solution 
{
    public int[] solution(long n) 
    {
        string str = n.ToString();
        int length = str.Length;
        
        int[] answer = new int[length];
        for(int i =0; i< length ; i++)
        {
            if(n>10)
            {
                answer[i] = (int)(n%10);
                n = n/10;
            }
            else
            {
                answer[i] = (int)(n%10);
            }
        }
        return answer;
    }
}