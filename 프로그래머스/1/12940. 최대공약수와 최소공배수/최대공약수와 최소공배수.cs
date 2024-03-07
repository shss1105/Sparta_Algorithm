public class Solution 
{
    public int[] solution(int n, int m) 
    {
        int[] answer = new int[2];

        if(n % m == 0 || m % n == 0)
        {
            if(n>m)
            {
                answer[0] = m;
                answer[1] = m * (n / m);
            }
            else
            {
                answer[0] = n;
                answer[1] = n * (m / n);
            }
        }
        else
        {
            int temp = 0;
            int num1 = n;
            int num2 = m;

            if(n<m)
            {
                while (num2 != 0)
                {
                    temp = num1 % num2;
                    num1 = num2;
                    num2 = temp;
                }
                answer[0] = num1;
                answer[1] = num1 * (m/num1) * (n/num1);
            }
            else
            {
                while (num1 != 0)
                {
                    temp = num2 % num1;
                    num2 = num1;
                    num1 = temp;
                }
                answer[0] = num2;
                answer[1] = num2 * (n/num2) * (m/num2);
            }
        }
        return answer;
    }
}