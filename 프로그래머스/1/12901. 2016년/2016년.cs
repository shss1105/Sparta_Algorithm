public class Solution 
{
    public string[] days = new string[7]{"FRI","SAT","SUN","MON","TUE","WED","THU"};
    public int[] dayOfMonth = new int[12]{31,29,31,30,31,30,31,31,30,31,30,31};
    
    public string solution(int a, int b) 
    {
        int day = 0;
        
        for(int i = 0; i < a - 1; i++)
        {
            day += dayOfMonth[i];
        }
        
        day += b - 1;
         
        string answer = days[day%7];
        return answer;
    }
}