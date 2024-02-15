public class Solution 
{
    public string solution(string phone_number) 
    {
        string answer = "";
        int numLength = phone_number.Length;
        
        for(int i =0; i< phone_number.Length; i++)
        {
            if(numLength >= 5)
            {
                answer += "*";
                numLength--;
                continue;
            }
            answer += phone_number[i];
        }
        
        return answer;
    }
}