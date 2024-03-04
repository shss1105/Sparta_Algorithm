public class Solution 
{
    public bool solution(string s) 
    {
        bool answer = false;
        int num;
            
        if(s.Length == 4 || s.Length == 6)
        {
            answer = int.TryParse(s,out num);
        }

        return answer;
    }
}