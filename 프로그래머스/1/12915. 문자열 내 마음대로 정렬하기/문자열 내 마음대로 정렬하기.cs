using System.Linq;

public class Solution 
{
    public string[] solution(string[] strings, int n)
        => strings.ToList().OrderBy(x=> x).OrderBy(x => x[n]).ToArray();
}