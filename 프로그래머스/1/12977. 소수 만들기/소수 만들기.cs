using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0; 
         
        int sum = 0;                

        for(int i=0; i < nums.Length; i++) 
        { 
            for(int j= i+1; j < nums.Length; j++) 
            { 
                for(int q = j+1; q < nums.Length; q++) 
                { 
                    sum = nums[i] + nums[j] + nums[q]; 

                    for(int k=2; k < sum; k++)
                    {
                        if(sum % k == 0) 
                        break; 
                        else 
                        { 
                            if(k == sum -1) 
                                answer++; 
                        } 
                    }
                } 
            } 
        }         
        return answer; 
    } 
}